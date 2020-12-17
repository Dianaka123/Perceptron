using System.Drawing;

namespace Perceptron.Core
{
    public class Matrix<T> where T: struct
    {
        private readonly T[,] values;

        public Size Size { get; private set; }

        public Matrix(Size size)
        {
            Size = size;
            values = new T[size.Width, size.Height];
        }

        public T this[int x, int y] 
        {
            get => values[x, y];
            set => values[x, y] = value;
        }
    }
}
