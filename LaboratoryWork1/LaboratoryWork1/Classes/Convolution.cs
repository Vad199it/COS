using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Drawing;

namespace LaboratoryWork1.Classes
{
    public static class Convolution
    {
        public static Bitmap ApplyFilter(Bitmap sourceBmp, int[,] kernel, int divider, FilterMode filterMode, bool substractFromSource)
        {
            RGB sourceRGB = GetRGB(sourceBmp);
            RGB filteredRGB = sourceRGB.Copy();

            for (int x = kernel.GetLength(0) / 2; x < sourceRGB.Width - kernel.GetLength(0) / 2; x++)
            {
                for (int y = kernel.GetLength(0) / 2; y < sourceRGB.Height - kernel.GetLength(0) / 2; y++)
                {
                    int rSum = 0,
                    gSum = 0,
                    bSum = 0;

                    for (int i = x - kernel.GetLength(0) / 2; i <= x + kernel.GetLength(0) / 2; i++)
                    {
                        for (int j = y - kernel.GetLength(0) / 2; j <= y + kernel.GetLength(0) / 2; j++)
                        {
                            rSum += sourceRGB.R[i, j] * kernel[i - (x - kernel.GetLength(0) / 2), j - (y - kernel.GetLength(0) / 2)];
                            gSum += sourceRGB.G[i, j] * kernel[i - (x - kernel.GetLength(0) / 2), j - (y - kernel.GetLength(0) / 2)];
                            bSum += sourceRGB.B[i, j] * kernel[i - (x - kernel.GetLength(0) / 2), j - (y - kernel.GetLength(0) / 2)];
                        }
                    }

                    if (!substractFromSource)
                    {
                        filteredRGB.R[x, y] = rSum / divider;
                        filteredRGB.G[x, y] = gSum / divider;
                        filteredRGB.B[x, y] = bSum / divider;
                    }
                    else
                    {
                        filteredRGB.R[x, y] = sourceRGB.R[x, y] - (rSum / divider);
                        filteredRGB.G[x, y] = sourceRGB.G[x, y] - (gSum / divider);
                        filteredRGB.B[x, y] = sourceRGB.B[x, y] - (bSum / divider);
                    }

                    switch (filterMode)
                    {
                        case FilterMode.ClampingOnly:
                            filteredRGB.R[x, y] = Math.Min(Math.Max(filteredRGB.R[x, y], 0), 255);
                            filteredRGB.G[x, y] = Math.Min(Math.Max(filteredRGB.G[x, y], 0), 255);
                            filteredRGB.B[x, y] = Math.Min(Math.Max(filteredRGB.B[x, y], 0), 255);
                            break;
                        case FilterMode.AbsAndClamping:
                            filteredRGB.R[x, y] = Math.Min(Math.Abs(filteredRGB.R[x, y]), 255);
                            filteredRGB.G[x, y] = Math.Min(Math.Abs(filteredRGB.G[x, y]), 255);
                            filteredRGB.B[x, y] = Math.Min(Math.Abs(filteredRGB.B[x, y]), 255);
                            break;
                        case FilterMode.Add128AndClamping:
                            filteredRGB.R[x, y] = Math.Min(Math.Max(filteredRGB.R[x, y] + 128, 0), 255);
                            filteredRGB.G[x, y] = Math.Min(Math.Max(filteredRGB.G[x, y] + 128, 0), 255);
                            filteredRGB.B[x, y] = Math.Min(Math.Max(filteredRGB.B[x, y] + 128, 0), 255);
                            break;
                        case FilterMode.Add128AbsAndClamping:
                            filteredRGB.R[x, y] = Math.Min(Math.Abs(filteredRGB.R[x, y] + 128), 255);
                            filteredRGB.G[x, y] = Math.Min(Math.Abs(filteredRGB.G[x, y] + 128), 255);
                            filteredRGB.B[x, y] = Math.Min(Math.Abs(filteredRGB.B[x, y] + 128), 255);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }

            return CreateBitmap(filteredRGB);
        }

        private static RGB GetRGB(Bitmap bmp)
        {
            RGB rgb = new RGB(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color clr = bmp.GetPixel(x, y);

                    rgb.R[x, y] = clr.R;
                    rgb.G[x, y] = clr.G;
                    rgb.B[x, y] = clr.B;
                }
            }

            return rgb;
        }

        private static Bitmap CreateBitmap(RGB rgb)
        {
            Bitmap bmp = new Bitmap(rgb.Width, rgb.Height);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(rgb.R[x, y], rgb.G[x, y], rgb.B[x, y]));
                }
            }

            return bmp;
        }
    }
}
