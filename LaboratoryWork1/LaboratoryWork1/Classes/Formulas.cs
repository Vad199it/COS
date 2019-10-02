﻿using System;
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
            double[] values = new double[formula.N*4];
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

                values[i] = formula.Amplitude1 * Math.Sin((2 * Math.PI * formula.Frequency1 * i) / formula.N + formula.InitialPhase) + y1;
            }
            return values;
        }

        public static double[] Square(Formula formula)
        {
            double[] values = new double[formula.N*4];
            Random rand = new Random();
            for (int i = 1; i < values.Length; i++)
            {
                double y1 = 0;
                if (formula.Noise)
                {
                    y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
                    if (i % 2 == 0)
                        y1 *= -1;
                }

                values[i] = formula.Amplitude1 * Math.Sign(formula.Amplitude1 * Math.Sin(2 * Math.PI * formula.Frequency1 * i / formula.N + formula.InitialPhase)) + y1;
            }
            return values;
        }

        public static double[] Triangle(Formula formula)
        {
            double[] values = new double[formula.N*4];
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

                values[i] = y1 + (2 * formula.Amplitude1 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency1 * i / values.Length + formula.InitialPhase));
            }
            return values;
        }

        public static double[] Sowtooth(Formula formula)
        {
            double[] values = new double[formula.N*4];
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
                double tan = Math.Tan(2 * Math.PI * formula.Frequency1 * i / values.Length + formula.InitialPhase);
                if (tan != 0)
                {
                    values[i] = (-2 * formula.Amplitude1 / Math.PI) * Math.Atan(1 / tan) + y1;
                }
                else values[i] = 0;
            }
            return values;
        }

        public static double[] HarmonicSquare(Formula formula)
        {
            double[] values = new double[formula.N * 4];
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

                values[i] = formula.Amplitude * Math.Sin((2 * Math.PI * formula.Frequency * i) / formula.N + formula.InitialPhase) + y1 + formula.Amplitude * Math.Sign(formula.Amplitude * Math.Sin(2 * Math.PI * formula.Frequency * i / formula.N + formula.InitialPhase));
            }
            return values;
        }

        public static double[] SquareTriangle(Formula formula)
        {
            double[] values = new double[formula.N * 4];
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

                values[i] = formula.Amplitude * Math.Sign(formula.Amplitude * Math.Sin(2 * Math.PI * formula.Frequency * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase));
            }
            return values;
        }

        public static double[] TriangleSowtooth(Formula formula)
        {
            double[] values = new double[formula.N * 4];
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

                double tan = Math.Tan(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase);
                if (tan != 0)
                {
                    values[i] = (-2 * formula.Amplitude / Math.PI) * Math.Atan(1 / tan) + y1 + (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase));
                }
                else values[i] = (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase)) + y1;
            }
            return values;
        }

        public static double[] SowtoothHarmonic(Formula formula)
        {
            double[] values = new double[formula.N * 4];
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

                double tan = Math.Tan(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase);
                if (tan != 0)
                {
                    values[i] = (-2 * formula.Amplitude / Math.PI) * Math.Atan(1 / tan) + formula.Amplitude * Math.Sin((2 * Math.PI * formula.Frequency * i) / formula.N + formula.InitialPhase) + y1;
                }
                else values[i] = formula.Amplitude * Math.Sin((2 * Math.PI * formula.Frequency * i) / formula.N + formula.InitialPhase) + y1;
            }
            return values;
        }

        public static double[] HarmonicSquareTriangle(Formula formula)
        {
            double[] values = new double[formula.N * 4];
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

                values[i] = formula.Amplitude * Math.Sin((2 * Math.PI * formula.Frequency * i) / formula.N + formula.InitialPhase) + y1 + formula.Amplitude * Math.Sign(formula.Amplitude * Math.Sin(2 * Math.PI * formula.Frequency * i / formula.N + formula.InitialPhase)) + (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase));
            }
            return values;
        }

        public static double[] SquareTriangleSowtooth(Formula formula)
        {
            double[] values = new double[formula.N * 4];
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

                double tan = Math.Tan(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase);
                if (tan != 0)
                {
                    values[i] = (-2 * formula.Amplitude / Math.PI) * Math.Atan(1 / tan) + formula.Amplitude * Math.Sign(formula.Amplitude * Math.Sin(2 * Math.PI * formula.Frequency * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase));
                }
                else values[i] = formula.Amplitude * Math.Sign(formula.Amplitude * Math.Sin(2 * Math.PI * formula.Frequency * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase));
            }
            return values;
        }

        public static double[] All(Formula formula)
        {
            double[] values = new double[formula.N * 4];
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

                double tan = Math.Tan(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase);
                if (tan != 0)
                {
                    values[i] = formula.Amplitude * Math.Sin((2 * Math.PI * formula.Frequency * i) / formula.N + formula.InitialPhase)+(-2 * formula.Amplitude / Math.PI) * Math.Atan(1 / tan) + formula.Amplitude * Math.Sign(formula.Amplitude * Math.Sin(2 * Math.PI * formula.Frequency * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase));
                }
                else values[i] = formula.Amplitude * Math.Sin((2 * Math.PI * formula.Frequency * i) / formula.N + formula.InitialPhase)+formula.Amplitude * Math.Sign(formula.Amplitude * Math.Sin(2 * Math.PI * formula.Frequency * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency * i / values.Length + formula.InitialPhase));

            }
            return values;
        }
    }
}
