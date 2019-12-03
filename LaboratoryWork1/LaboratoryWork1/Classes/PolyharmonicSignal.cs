using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryWork1.ViewModels;

namespace LaboratoryWork1.Classes
{
    class PolyharmonicSignal : Signal
    {
        int[] A;
        double[] phi;
        double f;
        public PolyharmonicSignal(int[] amplitudes, double freq, double[] phases, int discrPoints, bool lowFr, bool highFr, bool lineFr, int highEdge, int lowEdge) : base(lowFr, highFr, lineFr, highEdge, lowEdge)
        {

            A = amplitudes;
            n = discrPoints;
            f = freq;
            phi = phases;
            
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
            Random rnd = new Random();

            for (int i = 0; i <= n - 1; i++)
            {
                double tm = 0;
                for (int j = 0; j <= 29; j++)
                {
                    tm += A[rnd.Next(7)] * Math.Cos(2 * Math.PI * i  * i / n + phi[rnd.Next(6)]);
                }
                sign[i] = tm;
            }
            return sign;
        }
    }
}
