using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perceptron.Interface;

namespace Perceptron
{
    public partial class RecognitionControl : UserControl
    {
        public IRecognitionManager Manager { get; set; }

        public RecognitionControl()
        {
            InitializeComponent();
            Reset();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = OpenFileDialog.FileName;
            var bitmap = Image.FromFile(fileName);

            UploadedImagePictureBox.Image = bitmap;

            UploadedPathLabel.Text = fileName;
            UploadedPathLabel.ForeColor = Color.Black;

            if (Manager != null)
            {
                string result = Manager.Recognize(bitmap);
                RecognitionResultLabel.Text = result != null ? result.ToString() : "U";
                RecognitionResultLabel.ForeColor = result != null ? Color.Black : Color.DarkRed;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            UploadedPathLabel.Text = "NONE";
            UploadedPathLabel.ForeColor = Color.Gray;

            RecognitionResultLabel.Text = "NONE";
            RecognitionResultLabel.ForeColor = Color.Gray;

            UploadedImagePictureBox.Image = null;

            WinFormsHelper.ConfigureImageFileDialog(OpenFileDialog);
        }
    }
}
