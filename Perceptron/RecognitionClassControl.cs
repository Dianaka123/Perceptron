using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Perceptron
{

    public delegate void ImageAddedHandler(string path, Bitmap bitmap);

    public partial class RecognitionClassControl : UserControl
    {
        private readonly BitmapManager bitmapManager = BitmapManager.Instance;
        private readonly Dictionary<string, Bitmap> bitmapDictionary = new Dictionary<string, Bitmap>();

        public event ImageAddedHandler ImageAdded;

        public RecognitionClassControl()
        {
            InitializeComponent();
            WinFormsHelper.ConfigureImageFileDialog(OpenFileDialog);
        }

        public void Setup(string description)
        {
            ClassNameLabel.Text = description;
        }

        public bool SubmitImageByPath(string path)
        {
            if (bitmapDictionary.ContainsKey(path))
            {
                MessageBox.Show(FindForm(), "The bitmap is already added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string name = Path.GetFileName(path);
            Bitmap bitmap = bitmapManager.GetBitmap(path);

            bitmapDictionary.Add(path, bitmap);

            ImageStackControl.AppendImage(name, bitmap);

            ImageAdded?.Invoke(path, bitmap);
            return true;
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string path = OpenFileDialog.FileName;
            SubmitImageByPath(path);
        }
    }
}
