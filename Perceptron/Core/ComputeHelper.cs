using Perceptron.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Perceptron.Core
{
    public static class ComputeHelper
    {
        private static readonly Random random = new Random();

        public static Matrix<T> RandomizeRelations<T>(this Matrix<T> matrix, IList<T> availableValues) where T: struct
        {
            Size size = matrix.Size;
            for (int x = 0; x < size.Width; x++)
            {
                var value = availableValues[random.Next(0, availableValues.Count)];
                matrix[x, random.Next(0, size.Height)] = value;
            }
            return matrix;
        }

        public static T[] RandomizeValues<T>(IList<T> availableValues, int count) where T : struct
        {
            var result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = availableValues[random.Next(0, availableValues.Count)];
            }
            return result;
        }

    }
}
