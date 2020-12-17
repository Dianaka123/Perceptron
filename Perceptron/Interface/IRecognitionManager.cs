using System.Drawing;

namespace Perceptron.Interface
{
    public interface IRecognitionManager
    {
        string Recognize(Image image);
    }

    public interface ILearnManager
    {
        void SubmitImage(string classId, Image image);
    }
}
