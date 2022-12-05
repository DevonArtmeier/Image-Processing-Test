using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessTest
{
    internal class SobelOverlay
    {
        private static int AlphaBlend(int back, int front, float alpha)
        {
            return (int)((alpha * front) + ((1 - alpha) * back));
        }

        public static Image Process(Image image, Image sobelImage, int xOffset, int yOffset, Color color, float alpha)
        {
            Image procImage = image.Clone();
            int xOffPx = (int)((xOffset / 100.0) * image.Width);
            int yOffPx = (int)((yOffset / 100.0) * image.Height);

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    Color src = image.Pixels[x, y];
                    Color sobel = sobelImage.GetPixel(x - xOffPx, y - yOffPx);
                    float calcAlpha = (sobel.R / 255.0f) * alpha;

                    int r = AlphaBlend(src.R, color.R, calcAlpha);
                    int g = AlphaBlend(src.G, color.G, calcAlpha);
                    int b = AlphaBlend(src.B, color.B, calcAlpha);

                    procImage.Pixels[x, y] = Color.FromArgb(r, g, b);
                }
            return procImage;
        }
    }
}
