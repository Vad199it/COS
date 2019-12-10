using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryWork1.Classes
{
    public sealed class RGB
    {
        public RGB(int width, int height)
        {
            Width = width;
            Height = height;

            R = new int[Width, Height];
            G = new int[Width, Height];
            B = new int[Width, Height];
        }

        public int[,] R { get; }

        public int[,] G { get; }

        public int[,] B { get; }

        public int Width { get; }

        public int Height { get; }

        public RGB Copy()
        {
            RGB copy = new RGB(this.Width, this.Height);

            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    copy.R[i, j] = R[i, j];
                    copy.G[i, j] = G[i, j];
                    copy.B[i, j] = B[i, j];
                }
            }

            return copy;
        }
    }
}
