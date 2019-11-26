using System;
using System.Numerics;

namespace LaboratoryWork1.Classes
{
    public class FFT
    {
            /// <summary>
            /// Вычисление поворачивающего модуля e^(-i*2*PI*k/N)
            /// </summary>
            /// <param name="k"></param>
            /// <param name="N"></param>
            /// <returns></returns>
            private static Complex w(int k, int N)
            {
                if (k % N == 0) return 1;
                double arg = -2 * Math.PI * k / N;
                return new Complex(Math.Cos(arg), Math.Sin(arg));
            }

            /// <summary>
            /// Возвращает спектр сигнала
            /// </summary>
            /// <param name="x">Массив значений сигнала. Количество значений должно быть степенью 2</param>
            /// <returns>Массив со значениями спектра сигнала</returns>
            public static Complex[] fft(Complex[] x)
            {
                Complex[] X;
                int N = x.Length;
                if (N == 2)
                {
                    X = new Complex[2];
                    X[0] = x[0] + x[1];
                    X[1] = x[0] - x[1];
                }
                else
                {
                    Complex[] x_even = new Complex[N / 2];
                    Complex[] x_odd = new Complex[N / 2];
                    for (int i = 0; i < N / 2; i++)
                    {
                        x_even[i] = x[2 * i];
                        x_odd[i] = x[2 * i + 1];
                    }
                    Complex[] X_even = fft(x_even);
                    Complex[] X_odd = fft(x_odd);
                    X = new Complex[N];
                    for (int i = 0; i < N / 2; i++)
                    {
                        X[i] = X_even[i] + w(i, N) * X_odd[i];
                        X[i + N / 2] = X_even[i] - w(i, N) * X_odd[i];
                    }
                }
                return X;
            }

            public static double[] RestoreSignal(Complex[] spectrum)
            {
                var result = new double[spectrum.Length];

                for (int i = 0; i <= spectrum.Length - 1; i++)
                {
                    double val = 0;
                    for (int j = 0; j <= 100 - 1; j++)
                    {
                        val += spectrum[j].Magnitude * Math.Cos(2 * Math.PI * i * j / spectrum.Length - spectrum[j].Phase);
                    }
                    result[i] = val/100;
                }

                return result;
            }

        public static double[] RestoreNFSignal(Complex[] spectrum)
        {
            var result = new double[spectrum.Length];

            for (int i = 0; i <= spectrum.Length - 1; i++)
            {
                double val = 0;
                for (int j = 0; j <= 100 - 1; j++)
                {
                    val += spectrum[j].Magnitude * Math.Cos(2 * Math.PI * i * j / spectrum.Length);
                }
                result[i] = val;
            }

            return result;
        }

        public static double[] GetAmplitudeSpectrum(Complex[] X)
            {
                var result = new double[X.Length];

                for (var i = 0; i < result.Length; i++)
                {
                    result[i] = X[i].Magnitude * 2 / X.Length;
                }

                return result;
            }

            public static double[] GetPhasesSpectrum(Complex[] X)
            {
                var result = new double[X.Length];

                var amplitudes = GetAmplitudeSpectrum(X);

                for (var i = 0; i < result.Length; i++)
                {
                    if (amplitudes[i] > 0.0001)
                    {
                        result[i] = X[i].Phase;
                    }
                    else
                    {
                        result[i] = 0;
                    }
                }

                return result;
            }          
        }
    }
