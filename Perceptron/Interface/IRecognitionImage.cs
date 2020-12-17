using System.Drawing;

namespace Perceptron.Interface
{
    public interface IRecognitionImage
    {
        Size Size { get; }
        int GetWeight(int x, int y);
    }

    public class BitmapRecognitionImage : IRecognitionImage
    {
        private readonly Bitmap bitmap;

        public Size Size => bitmap.Size;

        public BitmapRecognitionImage(Image bitmap, Size size) => this.bitmap = new Bitmap(bitmap, size);

        public int GetWeight(int x, int y)
        {
            // TODO: most the most optimized way of color extracting.
            Color color = bitmap.GetPixel(x, y);
            return color.GetBrightness() >= 0.5 ? 1 : 0;
        }
    }

}
