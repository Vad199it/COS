﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryWork1.Classes
{
    class HarmonicSignal : Signal
    {
        double A, f, phi;
        public HarmonicSignal(double amplitude, double freq, double phase, int discrPoints)
        {
            A = amplitude;
            n = discrPoints;
            f = freq;
            phi = phase;
            signal = GenerateSignal();
            sineSp = GetSineSpectrum();
            cosineSp = GetCosineSpectrum();
            amplSp = GetAmplSpectrum();
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
