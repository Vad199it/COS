using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryWork1.ViewModels;

namespace LaboratoryWork1.Classes
{
    class HarmonicSignal : Signal
    {
        double A, f, phi; 
        public HarmonicSignal(double amplitude, double freq, double phase, int discrPoints, bool lowFr, bool highFr, bool lineFr, int highEdge, int lowEdge) : base(lowFr, highFr, lineFr, highEdge, lowEdge)
        {
            A = amplitude;
            n = discrPoints;
            f = freq;
            phi = phase;
            signal = GenerateSignal();
            sineSp = GetSineSpectrum();
            cosineSp = GetCosineSpectrum();
            amplSp = GetAmplSpectrum(lowFr, highFr, lineFr, highEdge, lowEdge);
            phaseSp = GetPhaseSpectrum();
            restSignal = RestoreSignal(0, numHarm);
            nfSignal = RestoreNFSignal();
        }

        internal override double[] GenerateSignal()
        {
            double[] sign = new double[n];
            for (int i = 0; i <= n - 1; i++)
            {
                sign[i] = A * Math.Cos(2 * Math.PI * f * i / n + phi);
            }
            return sign;
        }

    }
}
