using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessTest
{
    internal class Sobel
    {
        public enum Type
        {
            X,
            Y,
            XY
        }

        public static Image Process(Image image, Type type, int intensity = 2)
        {
            Image grayImage = Grayscale.Process(image);
            Image sobelImage = new Image(image.Width, image.Height);

            int[,] sobel = {
                { 1, 0, -1 },
                { intensity, 0, -intensity },
                { 1, 0, -1 }
            };

            for (int y = 1; y < image.Height - 1; y++)
                for (int x = 1; x < image.Width - 1; x++)
                {
                    int sobelX, sobelY, sobelCalc;
                    int sobelColor = 0;
                    for (int sy = 0; sy < 3; sy++)
                    {
                        for (int sx = 0; sx < 3; sx++)
                        {
                            sobelX = sobel[sy, sx];
                            sobelY = sobel[sx, sy];

                            switch (type)
                            {
                                default:
                                case Type.X:
                                    sobelCalc = sobelX;
                                    break;
                                case Type.Y:
                                    sobelCalc = sobelY;
                                    break;
                                case Type.XY:
                                    sobelCalc = sobelX + sobelY;
                                    break;
                            }
                            sobelColor += sobelCalc * grayImage.Pixels[x + sx - 1, y + sy - 1].R;
                        }
                        sobelColor = Math.Clamp(sobelColor, 0, 255);

                        sobelImage.Pixels[x, y] = Color.FromArgb(sobelColor, sobelColor, sobelColor);
                    }
                }

            return sobelImage;
        }
    }
}
