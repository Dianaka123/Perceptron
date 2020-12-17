using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class ImageInfoControl : UserControl
    {
        public ImageInfoControl()
        {
            InitializeComponent();
        }

        public void Setup(string description, Bitmap image)
        {
            DescriptionLabel.Text = description;
            PictureBox.Image = image;
        }
    }
}
