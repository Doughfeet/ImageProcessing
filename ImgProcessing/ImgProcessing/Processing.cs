using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgProcessing
{
    class Processing
    {
        public Processing()
        {

        }

        static double lightenAmount = Form1.LightenAmount;
        static double darkenAmount = Form1.DarkenAmount;

        public static bool ConvertToGray(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c1 = bitmap.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;

                    bitmap.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return true;
        }

        public static bool ConvertToNegative(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c1 = bitmap.GetPixel(i, j); // get Pixel from color
                    int a = c1.A; //extraction ARGB from pixel color
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    // For negative value

                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;
                    bitmap.SetPixel(i, j, Color.FromArgb(a, r1, g1, b1)); // setting new color for negative processed image
                }
            }
            return true;
        }


        public static bool ToGrayScaleLuminosity(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c1 = bitmap.GetPixel(i, j);
                    var luminosity = ((0.21 * c1.R) + (0.72 * c1.G) + (0.07 * c1.B)) / 3;
                    var c = Convert.ToInt32(luminosity);
                    var newColor = Color.FromArgb(255, c, c, c);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            return true;
        }

        
        public static bool LightenImage(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c1 = bitmap.GetPixel(i, j);
                    var newColor = LightenColor(c1, lightenAmount);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            return true;
        }
        public static Color LightenColor(Color inColor, double lightenAmount)
        {
            return Color.FromArgb(
                inColor.A,
                (int)Math.Min(255, inColor.R + 255 * lightenAmount),
                (int)Math.Min(255, inColor.G + 255 * lightenAmount),
                (int)Math.Min(255, inColor.B + 255 * lightenAmount));
        }


        public static bool DarkenImage(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color c1 = bitmap.GetPixel(i, j);
                    var newColor = DarkenColor(c1, darkenAmount);
                    bitmap.SetPixel(i, j, newColor);
                }
            }
            return true;
        }
        public static Color DarkenColor(Color inColor, double darkenAmount)
        {
            return Color.FromArgb(
                inColor.A,
                (int)Math.Max(0, inColor.R - 255 * darkenAmount),
                (int)Math.Max(0, inColor.G - 255 * darkenAmount),
                (int)Math.Max(0, inColor.B - 255 * darkenAmount));
        }
    }
}
