using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessTest
{
    internal class Image
    {
        /// <summary>
        /// Pixels
        /// </summary>
        public Color[,] Pixels;

        /// <summary>
        /// Width
        /// </summary>
        public int Width { get { return Pixels.GetLength(0); } }

        /// <summary>
        /// Height
        /// </summary>
        public int Height { get { return Pixels.GetLength(1); } }

        /// <summary>
        /// Create image
        /// </summary>
        /// <param name="width">Width of image</param>
        /// <param name="height">Height of image</param>
        public Image(int width, int height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentException($"Invalid image size {width}x{height}.");
            Pixels = new Color[width, height];
        }

        /// <summary>
        /// Load image
        /// </summary>
        /// <param name="path">Image file path</param>
        public Image(string path)
        {
            Bitmap bmp = (Bitmap)System.Drawing.Image.FromFile(path);
            Pixels = new Color[bmp.Width, bmp.Height];
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                    Pixels[x, y] = bmp.GetPixel(x, y);
        }

        /// <summary>
        /// Clone image
        /// </summary>
        /// <returns>Cloned image</returns>
        public Image Clone()
        {
            Image image = new Image(Width, Height);
            Array.Copy(Pixels, image.Pixels, Pixels.Length);
            return image;
        }

        /// <summary>
        /// Convert to bitmap
        /// </summary>
        /// <returns>Covnerted image</returns>
        public Bitmap ToBitmap()
        {
            Bitmap bmp = new Bitmap(Width, Height);
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                    bmp.SetPixel(x, y, Pixels[x, y]);
            return bmp;
        }

        /// <summary>
        /// Save image
        /// </summary>
        /// <param name="path">Save path</param>
        public void Save(string path)
        {
            using (Bitmap bmp = ToBitmap())
                bmp.Save(path);
        }

        /// <summary>
        /// Get pixel
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <returns>Pixel</returns>
        public Color GetPixel(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < Width && y < Height)
                return Pixels[x, y];
            return Color.Empty;
        }

        /// <summary>
        /// Set pixel
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <param name="color">Color</param>
        public void SetPixel(int x, int y, Color color)
        {
            if (x >= 0 && y >= 0 && x < Width && y < Height)
                Pixels[x, y] = color;
        }
    }
}
