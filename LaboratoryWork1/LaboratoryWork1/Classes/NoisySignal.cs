using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryWork1.Classes
{
    public class NoisySignal : Signal
    {
        private double _a;
        private double _b;
        public NoisySignal(double a, double b, int points)
        {
            n = points;
            _a = a;
            _b = b;
            signal = GenerateSignal();
            sineSp = GetSineSpectrum(signal);
            cosineSp = GetCosineSpectrum(signal);
            amplSp = GetAmplSpectrum(sineSp, cosineSp);
            phaseSp = GetPhaseSpectrum(sineSp, cosineSp);
        }

        protected override double[] GenerateSignal()
        {
            var signal = new double[n];
            var rnd = new Random();

            for (var i = 0; i < n; i++)
            {
                signal[i] = _a * Math.Sin(2 * Math.PI * i / n);
                var noise = 0d;
                for (var j = 50; j <= 70; j++)
                {
                    noise += Math.Pow(-1, rnd.Next(0, 2)) * _b * Math.Sin(2 * Math.PI * i * j / n);
                }

                signal[i] += noise;
            }

            return signal;
        }

        // парабола 4-ой степени по 13 точек
        public double[] ParabolicSmooth(double[] signal)
        {
            var result = new double[n];
            for (var i = 6; i < result.Length - 6; i++)
            {
                result[i] = (110 * signal[i - 6] - 198 * signal[i - 5] - 135 * signal[i - 4] +
                110 * signal[i - 3] + 390 * signal[i - 2] + 600 * signal[i - 1] + 677 * signal[i] +
                600 * signal[i + 1] + 390 * signal[i + 2] + 110 * signal[i + 3] - 135 * signal[i + 4] -
                198 * signal[i + 5] + 110 * signal[i + 6]) / 2431;
            }

            return result;
        }

        public double[] MedianFilteringSmoothing(double[] signal, int windowSize)
        {
            var result = (double[])signal.Clone();
            var window = new List<double>();

            for (var i = 0; i < result.Length - windowSize; i++)
            {
                window.Clear();
                for (var j = i; j < i + windowSize; j++)
                {
                    window.Add(signal[j]);
                }
                window.Sort();
                result[i + windowSize / 2] = window[windowSize / 2 + 1];
            }

            return result;
        }

        public double[] MedianAverageFilteringSmoothing(double[] signal, int windowSize)
        {
            var result = (double[])signal.Clone();
            var window = new List<double>();
            var k = (windowSize - 1) / 2;

            for (var i = 0; i < result.Length - windowSize; i++)
            {
                window.Clear();
                for (var j = i; j < i + windowSize; j++)
                {
                    window.Add(signal[j]);
                }
                window.Sort();
                var croppedWindow = window.GetRange(k, window.Count - k);
                result[i + windowSize / 2] = croppedWindow.Average();
            }

            return result;
        }
    }
}
