using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessTest
{
    internal class HueShift
    {
        public static Image Process(Image image, double redShift, double greenShift, double blueShift, double invertShift)
        {
            Image procImage = image.Clone();

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    int red = image.Pixels[x, y].R;
                    int green = image.Pixels[x, y].G;
                    int blue = image.Pixels[x, y].B;

                    red = Math.Clamp((int)(red + ((255 - red * 2) * invertShift)), 0, 255);
                    green = Math.Clamp((int)(green + ((255 - green * 2) * invertShift)), 0, 255);
                    blue = Math.Clamp((int)(blue + ((255 - blue * 2) * invertShift)), 0, 255);

                    if (redShift >= 1)
                        red = Math.Clamp((int)(red + ((redShift - 1) * 255)), 0, 255);
                    else
                        red = Math.Clamp((int)(red * redShift), 0, 255);
                    if (greenShift >= 1)
                        green = Math.Clamp((int)(green + ((greenShift - 1) * 255)), 0, 255);
                    else
                        green = Math.Clamp((int)(green * greenShift), 0, 255);
                    if (blueShift >= 1)
                        blue = Math.Clamp((int)(blue + ((blueShift - 1) * 255)), 0, 255);
                    else
                        blue = Math.Clamp((int)(blue * blueShift), 0, 255);

                    procImage.Pixels[x, y] = Color.FromArgb(red, green, blue);
                }

            return procImage;
        }
    }
}
