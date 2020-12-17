using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    public class BitmapManager
    {
        public static readonly BitmapManager Instance = new BitmapManager();

        private readonly Dictionary<string, Bitmap> bitmapDictionary = new Dictionary<string, Bitmap>();

        public Bitmap GetBitmap(string path)
        {
            if (!bitmapDictionary.TryGetValue(path, out Bitmap bitmap))
            {
                bitmap = Bitmap.FromFile(path) as Bitmap;
                bitmapDictionary.Add(path, bitmap);
            }
            return bitmap;
        }
    }
}
