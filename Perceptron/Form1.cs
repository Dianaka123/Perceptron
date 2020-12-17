using Perceptron.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    { 
        private static readonly int[] AlphaSizes = new[] { 250, 250 };
        private static readonly int[] LambdaAvailableValues = new[] { 0, -1 };
        private static readonly int[] AlphaAvailableValues = new[] { -1, 1 };

        private static readonly Size FixedImageSize = new Size(30, 30);
        private static readonly string LearnImagesPath = "D:\\ImagesForLearning\\";

        private static readonly Dictionary<string, RecognitionClassInfo> Classes = new Dictionary<string, RecognitionClassInfo>
        {
            //{ "A", new RecognitionClassInfo { R = new int[] { 1, 0 }, AvailableLambdas = new[] { -1, -2 } } },
            //{ "B", new RecognitionClassInfo { R = new int[] { 0, 1 }, AvailableLambdas = new[] { 1, 0 } } },
            //{ "C", new RecognitionClassInfo { R = new int[] { 1, 1 }, AvailableLambdas = new[] { 1, 1 } } },
            //{ "D", new RecognitionClassInfo { R = new int[] { 0, 0 }, AvailableLambdas = new[] { -1, -1 } } }
            { "A", new RecognitionClassInfo { R = new int[] { 1, 0 }, AvailableLambdas = LambdaAvailableValues } },
            { "B", new RecognitionClassInfo { R = new int[] { 0, 1 }, AvailableLambdas = LambdaAvailableValues } },
            { "C", new RecognitionClassInfo { R = new int[] { 1, 1 }, AvailableLambdas = LambdaAvailableValues } },
            { "D", new RecognitionClassInfo { R = new int[] { 0, 0 }, AvailableLambdas = LambdaAvailableValues } }
        };

        private readonly Dictionary<string, RecognitionClassControl> classControls = new Dictionary<string, RecognitionClassControl>();
        private readonly RecognitionController recognitionController;
        private readonly Matrix<int>[] alphaMatrixes;

        public Form1()
        {
            InitializeComponent();

            int totalFixedPixelCount = FixedImageSize.Width * FixedImageSize.Height;
            alphaMatrixes = AlphaSizes.Select(v => new Matrix<int>(new Size(totalFixedPixelCount, v)).
                RandomizeRelations(AlphaAvailableValues)).ToArray();
            recognitionController = new RecognitionController(FixedImageSize, alphaMatrixes, Classes);
            RecognitionControl.Manager = recognitionController;

            InitializeAlphaTables();
            InitializeClasses();
            Learn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeClasses()
        {
            var classNames = Classes.Select(v => v.Key).ToArray();
            for (int i = 0; i < classNames.Length; i++)
            {
                string classId = classNames[i];
                var control = new RecognitionClassControl();
                control.Setup(classId);
                control.ImageAdded += (path, bitmap) =>
                {
                    recognitionController.SubmitImage(classId, bitmap);
                };

                var tabPage = new TabPage
                {
                    Text = $"Class {i + 1} ({classId})"
                };
                tabPage.Controls.Add(control);

                ClassesTabControl.TabPages.Add(tabPage);

                control.Dock = DockStyle.Fill;

                classControls.Add(classId, control);
            }
        }

        private void InitializeAlphaTables()
        {
            int totalPixelCount = FixedImageSize.Width * FixedImageSize.Height;
            for (int i = 0; i < alphaMatrixes.Length; i++)
            {
                var alphaSize = AlphaSizes[i];
                var title = $"Alphas ({alphaSize}x{totalPixelCount})";
                var alphaMatrix = alphaMatrixes[i];

                var control = new TableControl
                {
                    GroupText = title,
                    IsReadOnly = true
                };


                control.SuspendLayout();
                {
                    control.RowCount = totalPixelCount;
                    control.ColumnCount = alphaSize;

                    var rows = control.RowCollection;
                    for (int k = 0; k < totalPixelCount; k++)
                    {
                        rows[k].HeaderCell.Value = $"X{k + 1}";
                    }

                    var columns = control.ColumnCollection;
                    for (int k = 0; k < alphaSize; k++)
                    {
                        columns[k].HeaderCell.Value = $"A{k + 1}";
                    }

                    for (int x = 0; x < alphaSize; x++)
                    {
                        for (int y = 0; y < totalPixelCount; y++)
                        {
                            rows[y].Cells[x].Value = alphaMatrix[y, x];
                        }
                    }
                }
                control.ResumeLayout();

                var tabPage = new TabPage
                {
                    Text = title
                };
                tabPage.Controls.Add(control);

                control.Dock = DockStyle.Fill;

                AlphaTabControl.TabPages.Add(tabPage);
            }
        }

        private void Learn()
        {
            var classNames = Classes.Select(v => v.Key).ToArray();
            for (int i = 0; i < classNames.Length; i++)
            {
                string classId = classNames[i];
                RecognitionClassControl control = classControls[classId];
                string folderPath = $"{LearnImagesPath}{classId}";
                if (Directory.Exists(folderPath))
                {
                    string[] files = Directory.GetFiles(folderPath);
                    files = files.OrderBy(v => Path.GetFileName(v)).ToArray();
                    for (int k = 0; k < 1; k++)
                    {
                        control.SubmitImageByPath(files[k]);
                    }
                }
            }
        }
    }
}
