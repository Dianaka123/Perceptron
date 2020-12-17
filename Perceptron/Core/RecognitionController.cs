using Perceptron.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Perceptron.Core
{
    public class InternalRecognitionClassInfo
    {
        public string Id { get; set; }
        public int[][] Lambda { get; set; }

        public int[] Sum { get; set; }
        public int[] Y { get; set; }
        public int[] Sigmas { get; set; }
        public int[] LastSigmas { get; set; }
        public int Sigma { get; set; }
        public int[] Rs { get; set; }
        public int Ch { get; set; }
        public RecognitionClassInfo Info { get; set; }
        public bool IsValid { get; set; } = false;
    }

    public class RecognitionClassInfo
    { 
        public int[] R { get; set; }

        public int[] AvailableLambdas { get; set; }
    }

    public class RecognitionController : IRecognitionManager, ILearnManager
    {
        private readonly Size fixedImageSize;
        private readonly Matrix<int>[] alphaMatrixes;
        private readonly IDictionary<string, RecognitionClassInfo> classes;
        private readonly Dictionary<string, InternalRecognitionClassInfo> classDictionary = new Dictionary<string, InternalRecognitionClassInfo>();
        private readonly int[] commonLambda;

        public RecognitionController(Size fixedImageSize, Matrix<int>[] alphaMatrixes, IDictionary<string, RecognitionClassInfo> classes)
        {
            this.fixedImageSize = fixedImageSize;
            this.alphaMatrixes = alphaMatrixes;
            this.classes = classes;
            foreach (var pair in classes)
            {
                classDictionary.Add(pair.Key, new InternalRecognitionClassInfo
                {
                    Id = pair.Key,
                    Lambda = alphaMatrixes.Select(v => ComputeHelper.RandomizeValues(pair.Value.AvailableLambdas, v.Size.Height)).ToArray(),
                    Sigmas = alphaMatrixes.Select(v => 0).ToArray(),
                    LastSigmas = alphaMatrixes.Select(v => 0).ToArray(),
                    Rs = alphaMatrixes.Select(v => 0).ToArray(),
                    Info = pair.Value
                });
            }
            commonLambda = ComputeHelper.RandomizeValues(new int[] { 0, -1 }, alphaMatrixes[0].Size.Height);
        }

        public string Recognize(Image image)
        {
            var typedImage = new BitmapRecognitionImage(image, fixedImageSize);

            var ys = new int[alphaMatrixes.Length][];
            for (int i = 0; i < ys.Length; i++)
            {
                int[] sum = ComputeSum(alphaMatrixes[i], typedImage);
                ys[i] = ComputeY(sum, 1);
            }

            var sigmas = new int[alphaMatrixes.Length];


            var computedClasses = classes.Keys.
                Select(v => classDictionary[v]).
                Where(v => v.IsValid).
                Select(v =>
                {
                    for (int i = 0; i < v.Sigmas.Length; i++)
                    {
                        var sigma = ComputeSigma(v.Lambda[i], ys[i]);
                        sigmas[i] += sigma;
                        v.Sigmas[i] = sigma;
                        v.Sigma += sigma;
                    }
                    return v;
                }).ToArray();

            //var rs = sigmas.Select(v => GetR(v)).ToArray();
            //var result = classes.FirstOrDefault(v => v.Value.R.SequenceEqual(rs));
            //return result.Key;

            var result = computedClasses.OrderBy(v => v.Sigma).Last();

            return result != null ? result.Id : null;
        }

        private void Train(InternalRecognitionClassInfo classInfo, IRecognitionImage typedImage, int index)
        {
            int changes = 0;
            int[] sum = ComputeSum(alphaMatrixes[index], typedImage);
            int[] y = ComputeY(sum, 1);
            int sigma = ComputeSigma(commonLambda, y);
            int R = GetR(sigma);
            int expectedR = classInfo.Info.R[index];

            while (R != expectedR)
            {
                int changeStep = expectedR > R ? 1 : -1;
                changes += changeStep;
                //ComputeLambda(classInfo.Lambda[index], y, changeStep);
                ComputeLambda(commonLambda, y, changeStep);

                sigma = ComputeSigma(commonLambda, y);
                R = GetR(sigma);
            }

            foreach (var info in classDictionary.Values)
            {
                if (classInfo != info)
                {
                    ComputeLambda(commonLambda, y, -1);
                }
            }
        }

        public void SubmitImage(string classId, Image image)
        {
            var typedImage = new BitmapRecognitionImage(image, fixedImageSize);
            var classInfo = classDictionary[classId];
            classInfo.IsValid = true;
            for (int i = 0; i < alphaMatrixes.Length; i++)
            {
                Train(classInfo, typedImage, i);
            }
        }

        private static int GetR(int sigma) => sigma >= 0 ? 1 : 0;

        private static void ComputeLambda(int[] lambdaOut, int[] y, int value)
        {
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] != 0)
                {
                    lambdaOut[i] += value;
                }
            }
        }

        private static int ComputeSigma(int[] lambda, int[] y)
        {
            int result = 0;
            for (int i = 0; i < lambda.Length; i++)
            {
                result += lambda[i] * y[i];
            }
            return result;
        }

        private static int[] ComputeSum(Matrix<int> alphaMatrix, IRecognitionImage image)
        {
            var result = new int[alphaMatrix.Size.Height];
            for (int x = 0; x < alphaMatrix.Size.Height; x++)
            {
                result[x] = 0;
                for (int y = 0; y < alphaMatrix.Size.Width; y++)
                {
                    int imageY = y / image.Size.Width;
                    int imageX = y % image.Size.Width;
                    result[x] += alphaMatrix[y, x] * image.GetWeight(imageX, imageY);
                }
            }
            return result;
        }

        public static int[] ComputeY(int[] sum, int border) =>
            sum.Select(v => v >= border ? 1 : 0).ToArray();
    }
}
