using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessTest
{
    internal class Grayscale
    {
        public static Image Process(Image image)
        {
            Image grayImage = image.Clone();
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    Color col = image.Pixels[x, y];
                    int gray = (int)((col.R * 0.21) + (col.G * 0.71) + (col.B * 0.071));
                    grayImage.Pixels[x, y] = Color.FromArgb(gray, gray, gray);
                }
            return grayImage;
        }
    }
}
