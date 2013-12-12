﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace PrimeLib
{
    /// <summary>
    /// Generic utilities
    /// </summary>
    public static class Utilities
    {
        private static readonly Random Rnd = new Random();

        /// <summary>
        /// Returns a subarray of an array (<see href="http://stackoverflow.com/questions/943635/c-sharp-arrays-getting-a-sub-array-from-an-existing-array">Reference</see>)
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="data">Source</param>
        /// <param name="index">Start from</param>
        /// <param name="length">Lenght</param>
        /// <returns>Subarray</returns>
        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            var result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        internal static string GenerateProgramFromImage(string path, string name)
        {
            const int width = 320, height = 240, totalBytes = width * height * 3;
            const string defaultColor = "000000"; // RRGGBB
            var img = ResizeImage(Image.FromFile(path), width, height);
            var bmpData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            var p = new StringBuilder("EXPORT " + name + "()");
            p.Append("\nBEGIN\n");
            var rgbValues = new byte[totalBytes];

            // Copy the RGB values into the array.
            Marshal.Copy(bmpData.Scan0, rgbValues, 0, totalBytes);

            p.Append("RECT(#" + defaultColor + "h);\n");
            for (var x = 0; x < width; x++)
                for (var y = 0; y < height; y++)
                {
                    var c = GetColor(ref rgbValues, x, y, width);

                    if (c != defaultColor)
                        p.Append(String.Format("PIXON_P({0},{1},#{2}h);\n", x, y, c));
                }

            img.UnlockBits(bmpData);
            return p.Append("WAIT;END;").ToString();
        }

        private static string GetColor(ref byte[] rgbValues, int x, int y, int width)
        {
            var pos = x*3 + (y*width*3);
            return String.Format("{0:X2}{1:X2}{2:X2}",rgbValues[pos+2],rgbValues[pos + 1],rgbValues[pos]);
        }

        
        // 
        /// <summary>
        /// Resizes an Image to fit in a canvas (<see href="http://stackoverflow.com/questions/1940581/c-sharp-image-resizing-to-different-size-while-preserving-aspect-ratio">Reference</see>)
        /// </summary>
        /// <param name="image">Source image</param>
        /// <param name="maxWidth">Canvas width</param>
        /// <param name="maxHeight">Canvas height</param>
        /// <param name="returnIncludesCanvas">If the returned image should include the canvas padding</param>
        /// <returns>Resized image</returns>
        public static Bitmap ResizeImage(Image image, int maxWidth, int maxHeight, bool returnIncludesCanvas=true)
        {
            var newWidth = image.Width;
            var newHeight = image.Height;

            if (image.Width > maxHeight || image.Height > maxHeight)
            {
                var ratioX = (double) maxWidth/image.Width;
                var ratioY = (double) maxHeight/image.Height;
                var ratio = Math.Min(ratioX, ratioY);

                newWidth = (int) (image.Width*ratio);
                newHeight = (int) (image.Height*ratio);
            }

            if (returnIncludesCanvas)
            {
                var newImage = new Bitmap(maxWidth, maxHeight);
                Graphics.FromImage(newImage).DrawImage(image, (maxWidth - newWidth)/2, (maxHeight - newHeight)/2, newWidth, newHeight);
                return newImage;
            }
            else
            {
                var newImage = new Bitmap(newWidth, newHeight);
                Graphics.FromImage(newImage).DrawImage(image, 0,0, newWidth, newHeight);
                return newImage;
            }
        }

        /// <summary>
        /// Generates a random program name
        /// </summary>
        /// <returns>Random program name</returns>
        public static String GetRandomProgramName()
        {
            return "program_" + GetRandomChar() + Rnd.Next(10, 99);
        }

        /// <summary>
        /// Generates a random lowercase char
        /// </summary>
        /// <returns>Random char</returns>
        public static char GetRandomChar()
        {
            return (char) Rnd.Next('a', 'z' + 1);
        }
    }
}