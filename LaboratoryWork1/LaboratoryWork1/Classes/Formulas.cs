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
            double[] value = new double[formula.N];
            for (int i = 0; i <= formula.N - 1; i++)
            {
                value[i] = formula.Amplitude * Math.Cos(2 * Math.PI * formula.Frequency * i / formula.N + formula.InitialPhase);
            }
            return value;
            //double[] value2y = new double[formula.N * 10];
            //double[] value3y = new double[formula.N * 10];
            //double t = 0;
            //for (int M = formula.M; M <= 10 * formula.N - 1; M++)
            //{
            //    double A = 0;
            //    double rms_1 = 0, rms_2 = 0;
            //    double sin = 0;
            //    double cos = 0;
            //    for (int n = 1; n <= M; n++)
            //    {
            //        t = Math.Sin(2 * Math.PI * n / formula.N + formula.InitialPhase);
            //        rms_1 += Math.Pow(t, 2);
            //        rms_2 += t;
            //        sin += t * Math.Sin(2 * Math.PI * n / M);
            //        cos += t * Math.Cos(2 * Math.PI * n / M);
            //    }
            //    A = Math.Sqrt(Math.Pow(2 * sin / M, 2) + Math.Pow(2 * cos / M, 2));
            //    value1y[M] = 0.707 - Math.Sqrt(rms_1 / (M + 1));
            //    value2y[M] = 0.707 - (Math.Sqrt(rms_1 / (M + 1) - Math.Pow(rms_2 / (M + 1), 2)));
            //    value3y[M] = A;                           
            //}

            //var temp = new double[value1y.Length * 3];

            //for(int i = 0; i < value1y.Length; i++)
            //{
            //    temp[i] = value1y[i];
            //    temp[value1y.Length + i] = value2y[i];
            //    temp[value1y.Length * 2 + i] = value3y[i];
            //}

            //return temp;
        }

        //    public static double[] Square(Formula formula)
        //    {
        //        double[] values = new double[formula.N*4];
        //        Random rand = new Random();

        //        double Frequency = formula.Frequency;

        //        for (int i = 1; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            double Amplitude = formula.Amplitude;
        //            if (formula.Amplitudem)
        //            {
        //                Amplitude = (2 * formula.Amplitude2 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency2 * 10 * i / values.Length + formula.InitialPhase));
        //            };


        //            if (formula.Frequencym)
        //            {
        //                Frequency = Frequency + 0.01;//(2 * formula.Amplitude2 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency2 * i / values.Length + formula.InitialPhase)); //formula.Frequency1 + formula.Frequency2 * i;
        //            };

        //            values[i] = Amplitude * Math.Sign(Amplitude * Math.Sin(2 * Math.PI * Frequency * i / formula.N + formula.InitialPhase)) + y1;
        //        }
        //        return values;
        //    }

        //    public static double[] Triangle(Formula formula)
        //    {
        //        double[] values = new double[formula.N*4];
        //        Random rand = new Random();
        //        double Frequency = formula.Frequency;
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            double Amplitude = formula.Amplitude1;
        //            if (formula.Amplitudem)
        //            {
        //                Amplitude = formula.Amplitude2 * Math.Sign(formula.Amplitude2 * Math.Sin(2 * Math.PI * formula.Frequency2* 10* i / formula.N + formula.InitialPhase));
        //            };


        //            if (formula.Frequencym)
        //            {
        //                Frequency = Frequency + 0.01;//formula.Amplitude2 * Math.Sign(formula.Amplitude2 * Math.Sin(2 * Math.PI * formula.Frequency2 * i / formula.N + formula.InitialPhase)); //formula.Frequency1 + formula.Frequency2 * i;
        //            };

        //            values[i] = y1 + (2 * Amplitude / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * Frequency * i / values.Length + formula.InitialPhase));
        //        }
        //        return values;
        //    }

        //    public static double[] Sowtooth(Formula formula)
        //    {
        //        //double[] values = new double[formula.N*4];
        //        //Random rand = new Random();
        //        //double Frequency = formula.Frequency1;
        //        //for (int i = 0; i < values.Length; i++)
        //        //{
        //        //    double y1 = 0;
        //        //    if (formula.Noise)
        //        //    {
        //        //        y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //        //        if (i % 2 == 0)
        //        //            y1 *= -1;
        //        //    }

        //        //    double Amplitude = formula.Amplitude1;
        //        //    if (formula.Amplitudem)
        //        //    {
        //        //        Amplitude = Math.Sin((2 * Math.PI * formula.Frequency2 * i) / formula.N);
        //        //    };


        //        //    if (formula.Frequencym)
        //        //    {
        //        //        Frequency = Frequency + 0.01;//formula.Amplitude2 * Math.Sin((2 * Math.PI * formula.Frequency2 * i) / formula.N + formula.InitialPhase);//formula.Frequency1 + formula.Frequency2 * i;
        //        //    };

        //        //    double tan = Math.Tan(2 * Math.PI * Frequency * i / values.Length + formula.InitialPhase);
        //        //    if (tan != 0)
        //        //    {
        //        //        values[i] = (-2 * Amplitude / Math.PI) * Math.Atan(1 / tan) + y1;
        //        //    }
        //        //    else values[i] = 0;
        //        //}
        //        //return values;
        //        double[] value1y = new double[formula.N * 2];
        //        double[] value2y = new double[formula.N * 2];
        //        double[] value3y = new double[formula.N * 2];
        //        double t = 0;
        //        for (int M = formula.M; M <= 2 * formula.N - 1; M++)
        //        {
        //            double A = 0;
        //            double rms_1 = 0, rms_2 = 0;
        //            double sin = 0;
        //            double cos = 0;
        //            for (int n = 1; n <= M; n++)
        //            {
        //                double tan = Math.Tan(2 * Math.PI * n / (2 * formula.N) + formula.InitialPhase);
        //                if (tan != 0)
        //                {
        //                    t = (-2 / Math.PI) * Math.Atan(1 / tan);
        //                }
        //                else t = 0;
        //                rms_1 += Math.Pow(t, 2);
        //                rms_2 += t;
        //                sin += t * Math.Sin(2 * Math.PI * n / M);
        //                cos += t * Math.Cos(2 * Math.PI * n / M);
        //            }
        //            A = Math.Sqrt(Math.Pow(2 * sin / M, 2) + Math.Pow(2 * cos / M, 2));
        //            value1y[M] = 0.707 - Math.Sqrt(rms_1 / (M + 1));
        //            value2y[M] = 0.707 - (Math.Sqrt(rms_1 / (M + 1) - Math.Pow(rms_2 / (M + 1), 2)));
        //            value3y[M] = 1 - A;

        //        }
        //        var temp = new double[value1y.Length * 3];

        //        for (int i = 0; i < value1y.Length; i++)
        //        {
        //            temp[i] = value1y[i];
        //            temp[value1y.Length + i] = value2y[i];
        //            temp[value1y.Length * 2 + i] = value3y[i];
        //        }

        //        return temp;
        //    }

        //    public static double[] HarmonicSquare(Formula formula)
        //    {
        //        double[] values = new double[formula.N * 4];
        //        Random rand = new Random();
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            values[i] = formula.Amplitude1 * Math.Sin((2 * Math.PI * formula.Frequency1 * i) / formula.N + formula.InitialPhase) + y1 + formula.Amplitude2 * Math.Sign(formula.Amplitude2 * Math.Sin(2 * Math.PI * formula.Frequency2 * i / formula.N + formula.InitialPhase));
        //        }
        //        return values;
        //    }

        //    public static double[] SquareTriangle(Formula formula)
        //    {
        //        double[] values = new double[formula.N * 4];
        //        Random rand = new Random();
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            values[i] = formula.Amplitude1 * Math.Sign(formula.Amplitude1 * Math.Sin(2 * Math.PI * formula.Frequency1 * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude2 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency2 * i / values.Length + formula.InitialPhase));
        //        }
        //        return values;
        //    }

        //    public static double[] TriangleSowtooth(Formula formula)
        //    {
        //        double[] values = new double[formula.N * 4];
        //        Random rand = new Random();
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            double tan = Math.Tan(2 * Math.PI * formula.Frequency2 * i / values.Length + formula.InitialPhase);
        //            if (tan != 0)
        //            {
        //                values[i] = (-2 * formula.Amplitude2 / Math.PI) * Math.Atan(1 / tan) + y1 + (2 * formula.Amplitude2 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency2 * i / values.Length + formula.InitialPhase));
        //            }
        //            else values[i] = (2 * formula.Amplitude1 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency1 * i / values.Length + formula.InitialPhase)) + y1;
        //        }
        //        return values;
        //    }

        //    public static double[] SowtoothHarmonic(Formula formula)
        //    {
        //        double[] values = new double[formula.N * 4];
        //        Random rand = new Random();
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            double tan = Math.Tan(2 * Math.PI * formula.Frequency1 * i / values.Length + formula.InitialPhase);
        //            if (tan != 0)
        //            {
        //                values[i] = (-2 * formula.Amplitude1 / Math.PI) * Math.Atan(1 / tan) + formula.Amplitude2 * Math.Sin((2 * Math.PI * formula.Frequency2 * i) / formula.N + formula.InitialPhase) + y1;
        //            }
        //            else values[i] = formula.Amplitude2 * Math.Sin((2 * Math.PI * formula.Frequency2 * i) / formula.N + formula.InitialPhase) + y1;
        //        }
        //        return values;
        //    }

        //    public static double[] HarmonicSquareTriangle(Formula formula)
        //    {
        //        double[] values = new double[formula.N * 4];
        //        Random rand = new Random();
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            values[i] = formula.Amplitude1 * Math.Sin((2 * Math.PI * formula.Frequency1 * i) / formula.N + formula.InitialPhase) + y1 + formula.Amplitude2 * Math.Sign(formula.Amplitude2 * Math.Sin(2 * Math.PI * formula.Frequency2 * i / formula.N + formula.InitialPhase)) + (2 * formula.Amplitude3 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency3 * i / values.Length + formula.InitialPhase));
        //        }
        //        return values;
        //    }

        //    public static double[] SquareTriangleSowtooth(Formula formula)
        //    {
        //        double[] values = new double[formula.N * 4];
        //        Random rand = new Random();
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            double tan = Math.Tan(2 * Math.PI * formula.Frequency3 * i / values.Length + formula.InitialPhase);
        //            if (tan != 0)
        //            {
        //                values[i] = (-2 * formula.Amplitude3 / Math.PI) * Math.Atan(1 / tan) + formula.Amplitude1 * Math.Sign(formula.Amplitude1 * Math.Sin(2 * Math.PI * formula.Frequency1 * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude2 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency2 * i / values.Length + formula.InitialPhase));
        //            }
        //            else values[i] = formula.Amplitude1 * Math.Sign(formula.Amplitude1 * Math.Sin(2 * Math.PI * formula.Frequency1 * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude2 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency2 * i / values.Length + formula.InitialPhase));
        //        }
        //        return values;
        //    }

        //    public static double[] All(Formula formula)
        //    {
        //        double[] values = new double[formula.N * 4];
        //        Random rand = new Random();
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            double y1 = 0;
        //            if (formula.Noise)
        //            {
        //                y1 = rand.NextDouble() * (0.2 - 0.1) + 0.1;
        //                if (i % 2 == 0)
        //                    y1 *= -1;
        //            }

        //            double tan = Math.Tan(2 * Math.PI * formula.Frequency4 * i / values.Length + formula.InitialPhase);
        //            if (tan != 0)
        //            {
        //                values[i] = formula.Amplitude1 * Math.Sin((2 * Math.PI * formula.Frequency1 * i) / formula.N + formula.InitialPhase)+(-2 * formula.Amplitude4 / Math.PI) * Math.Atan(1 / tan) + formula.Amplitude2 * Math.Sign(formula.Amplitude2 * Math.Sin(2 * Math.PI * formula.Frequency2 * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude3 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency3 * i / values.Length + formula.InitialPhase));
        //            }
        //            else values[i] = formula.Amplitude1 * Math.Sin((2 * Math.PI * formula.Frequency1 * i) / formula.N + formula.InitialPhase) + formula.Amplitude2 * Math.Sign(formula.Amplitude2 * Math.Sin(2 * Math.PI * formula.Frequency2 * i / formula.N + formula.InitialPhase)) + y1 + (2 * formula.Amplitude3 / Math.PI) * Math.Asin(Math.Sin(2 * Math.PI * formula.Frequency3 * i / values.Length + formula.InitialPhase));

        //        }
        //        return values;
        //    }
        //}
    }
}
