using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace DevelopStuff.Examples.ColorChart.Core
{
    public class ColorImage
    {

        #region Constructor

        private ColorImage()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Saves the file.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="format"></param>
        /// <param name="filePath"></param>
        public static void SaveFile(Size size, ImageFormat format, string filePath)
        {
            Bitmap colorChart = GenerateBitmap(size);

            if((format == ImageFormat.Jpeg) || (format == ImageFormat.Png) || (format == ImageFormat.Bmp) || (format == ImageFormat.Gif))
            {
                colorChart.Save(filePath, format);
            }   
        }

        /// <summary>
        /// Generates the bitmap.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        private static Bitmap GenerateBitmap(Size size)
        {
            Bitmap chart = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(chart);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            g.Clear(Color.White);

            using (SolidBrush nameBrush = new SolidBrush(Color.Black))
            using (Font nameFont = new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Pixel))
            {
                int X = 0;
                int Y = 0;
                int swatchWidth = 100;
                int swatchHeight = 100;

                foreach (Color color in ColorGenerator.Instance.Colors)
                {
               
                    // Create a 80,80 80 square.
                    Rectangle swatch = new Rectangle(X + 10, Y + 10, swatchWidth - 20, swatchHeight - 20);

                    using(SolidBrush colorBrush = new SolidBrush(color))
                    {
                        g.FillRectangle(colorBrush, swatch);
                    }

                    // Measure the output string.
                    SizeF colorNameSize = g.MeasureString(color.Name, nameFont);

                    // Take either the outside of the swatch or center the label.
                    int calculatedX = (colorNameSize.Width >= swatchWidth) ? X : X + (int) (swatchWidth - colorNameSize.Width) / 2;

                    Rectangle swatchLabel = new Rectangle(calculatedX, Y + swatchHeight - 10, swatchWidth, Y);

                    g.DrawString(color.Name, nameFont, nameBrush, swatchLabel);

                    if ((X + (2 * swatchWidth)) > (size.Width))
                    {
                        X = 0;
                        Y += swatchHeight;
                    }
                    else
                    {
                        X += swatchWidth;
                    }
                }

            }

            return chart;
        }

        #endregion

    }
}
