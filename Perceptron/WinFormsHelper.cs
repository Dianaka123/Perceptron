using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    static class WinFormsHelper
    {
        private static readonly (string Name, string Description)[] SupportedFormats = new[]
        {
            (Name: "*", Description: "All files"),
            (Name: "png", Description: "Image format"),
            (Name: "jpg", Description: "Image format"),
            (Name: "bmp", Description: "Image format")
        };

        public static void ConfigureImageFileDialog(FileDialog fileDialog)
        {
            fileDialog.Filter = SupportedFormats.Aggregate(new StringBuilder(),
             (acc, v) => acc.Append($"{v.Description} (*.{v.Name})|*.{v.Name}|"),
             builder => builder.Remove(builder.Length - 1, 1)).ToString();
            fileDialog.FilterIndex = 1;
        }

    }
}
