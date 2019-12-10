using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryWork1.ViewModels;

namespace LaboratoryWork1.Classes
{
        public abstract class Signal
        {
            protected int n;
            protected double[] signal;
            protected double[] sineSp, cosineSp;
            protected double[] amplSp, phaseSp;
            protected int valueCount = 100;

            public Signal()
            {

            }

            public double[] SignalVal => signal;
            public double[] AmplSpectrum => amplSp;
            public double[] PhaseSpectrum => phaseSp;

            protected virtual double[] GenerateSignal()
            {
                return null;
            }

            public double[] GetCosineSpectrum(double[] signal)
            {
                var result = new double[valueCount];
                for (var j = 0; j < result.Length; j++)
                {
                    var val = 0d;
                    for (var i = 0; i < n; i++)
                    {
                        val += signal[i] * Math.Cos(2 * Math.PI * i * j / n);
                    }

                    result[j] = 2 * val / n;
                }

                return result;
            }

            public double[] GetSineSpectrum(double[] signal)
            {
                var result = new double[valueCount];
                for (int j = 0; j < result.Length; j++)
                {
                    var val = 0d;
                    for (var i = 0; i < n; i++)
                    {
                        val += signal[i] * Math.Sin(2 * Math.PI * i * j / n);
                    }

                    result[j] = val;
                }

                return result;
            }

            public double[] GetAmplSpectrum(double[] sineSp, double[] cosineSp)
            {
                var result = new double[valueCount];
                for (var i = 0; i < result.Length; i++)
                {
                    result[i] = Math.Sqrt(Math.Pow(sineSp[i], 2) + Math.Pow(cosineSp[i], 2));
                }

                return result;
            }

            public double[] GetPhaseSpectrum(double[] sineSp, double[] cosineSp)
            {
                var result = new double[valueCount];
                for (var i = 0; i < result.Length; i++)
                {
                    result[i] = Math.Atan(sineSp[i] / cosineSp[i]);
                }

                return result;
            }
        }
    }
