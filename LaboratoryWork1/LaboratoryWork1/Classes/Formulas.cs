using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryWork1.ViewModels;

namespace LaboratoryWork1.Classes
{
    public static class Formulas
    {
        public static double[] Harmonic(Formula formula)
        {
            double[] values = new double[formula.N];
            Random rand = new Random();
            for (int i = 0; i < values.Length; i++)
            {
                double y1 = 0;
                if (formula.Noise)
                {
                    y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
                    if (i % 2 == 0)
                        y1 *= -1;
                }

                values[i] = formula.Amplitude * Math.Sin((2 * Math.PI * formula.Frequency * i) / formula.N + formula.InitialPhase) + y1;
            }
            return values;
        }

        public static double[] Sinus(Formula formula)
        {
            double[] values = new double[formula.N];
            Random rand = new Random();
            for (int i = 0; i < values.Length; i++)
            {
                double y1 = 0;
                if (formula.Noise)
                {
                    y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
                    if (i % 2 == 0)
                        y1 *= -1;
                }
                double sinus = Math.Sin(formula.Frequency * i + formula.InitialPhase);
                values[i] = formula.Amplitude*Math.Sin(i);
            }
            return values;
        }

        public static double[] Square(Formula formula)
        {
            double[] values = new double[formula.N];
            Random rand = new Random();
            for (int i = 0; i < values.Length; i++)
            {
                double y1 = 0;
                if (formula.Noise)
                {
                    y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
                    if (i % 2 == 0)
                        y1 *= -1;
                }

                values[i] = formula.Amplitude * Math.Sin(formula.Frequency * i + formula.InitialPhase) + y1;
            }
            return values;
        }

        public static double[] Triangle(Formula formula)
        {
            double[] values = new double[formula.N];
            Random rand = new Random();
            for (int i = 0; i < values.Length; i++)
            {
                double y1 = 0;
                if (formula.Noise)
                {
                    y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
                    if (i % 2 == 0)
                        y1 *= -1;
                }

                values[i] = (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(formula.N));
            }
            return values;
        }

        public static double[] Sowtooth(Formula formula)
        {
            double[] values = new double[formula.N];
            Random rand = new Random();
            for (int i = 0; i < values.Length; i++)
            {
                double y1 = 0;
                if (formula.Noise)
                {
                    y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
                    if (i % 2 == 0)
                        y1 *= -1;
                }
                double tan = Math.Tan(formula.N / 2);
                if (tan != 0)
                {
                    values[i] = (-2 * formula.Amplitude / Math.PI) * Math.Atan(1 / tan);
                }
                else values[i] = 0;

                //values[i] = (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(formula.N));
            }
            return values;
        }
    }
}
