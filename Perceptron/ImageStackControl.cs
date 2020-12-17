
using System.Drawing;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class ImageStackControl : UserControl
    {
        public ImageStackControl()
        {
            InitializeComponent();
        }

        public void AppendImage(string description, Bitmap image)
        {
            var imageControl = new ImageInfoControl();
            imageControl.Setup(description, image);
            imageControl.Height = 100;
            LayoutPanel.Controls.Add(imageControl);
            imageControl.Dock = DockStyle.Top;
        }

        public void ClearImages()
        {
            LayoutPanel.Controls.Clear();
        }
    }
}
