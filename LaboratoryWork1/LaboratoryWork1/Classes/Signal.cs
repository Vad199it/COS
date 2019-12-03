﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratoryWork1.ViewModels;

namespace LaboratoryWork1.Classes
{
    class Signal
    {
        internal int n;
        internal double[] signal, restSignal, nfSignal;
        internal double[] sineSp, cosineSp;
        internal double[] amplSp, phaseSp;
        internal int numHarm = 100;
        bool low, high, line;
        int highE, lowE;
        public Signal(bool lowFr, bool highFr, bool lineFr, int highEdge, int lowEdge)
        {
            low = lowFr;
            high = highFr;
            line = lineFr;
            highE = highEdge;
            lowE = lowEdge;
            signal = GenerateSignal();
            sineSp = GetSineSpectrum();
            cosineSp = GetCosineSpectrum();
            amplSp = GetAmplSpectrum(low, high, line, highE, lowE);
            phaseSp = GetPhaseSpectrum();
            restSignal = RestoreSignal(0, numHarm);
            nfSignal = RestoreNFSignal();
        }
        public double[] signVal { get { return signal; } }
        public double[] amplSpectrum { get { return amplSp; } }
        public double[] phaseSpectrum { get { return phaseSp; } }
        public double[] restoredSignal { get { return restSignal; } }
        public double[] restorednonphasedSignal { get { return nfSignal; } }

        internal virtual double[] GenerateSignal()
        {
            return null;
        }

        internal double[] GetSineSpectrum()
        {
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
            {
                double val = 0;
                for (int i = 0; i <= n - 1; i++)
                {
                    val += signal[i] * Math.Sin(2 * Math.PI * i * j / n);
                }
                values[j] = 2 * val / n;
            }
            return values;
        }

        internal double[] GetCosineSpectrum()
        {
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
            {
                double val = 0;
                for (int i = 0; i <= n - 1; i++)
                {
                    val += signal[i] * Math.Cos(2 * Math.PI * i * j / n);
                }
                values[j] = 2 * val / n;
            }
            return values;
        }

        internal double[] GetAmplSpectrum(bool low, bool high, bool line, int highEdge, int lowEdge)
        {
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
            {
                values[j] = Math.Sqrt(Math.Pow(sineSp[j], 2) + Math.Pow(cosineSp[j], 2));
                if (low)
                {
                    if (j > 0 && j <= highEdge)
                    values[j] = values[j];
                    else values[j] = 0;
                }
                if (high)
                {
                    if (j < lowEdge || j > 150)
                    {
                        if (j < lowEdge) values[j] = 0;
                        if (j > 150) values[j] = values[j];
                    }
                }
                if (line)
                {
                    if (j < lowEdge || j > highEdge)
                    {
                        if (j < lowEdge) values[j] = 0;
                        if (j > highEdge) values[j] = 0;
                    }
                }
            }
            
            return values;
        }

        internal double[] GetPhaseSpectrum()
        {
            double[] values = new double[numHarm];
            for (int j = 0; j <= numHarm - 1; j++)
            {
                values[j] = Math.Atan(sineSp[j] / cosineSp[j]);
            }
            return values;
        }

        internal double[] RestoreSignal(int a, int b)
        {
            double[] values = new double[n];
            for (int i = 0; i <= n - 1; i++)
            {
                double val = 0;
                for (int j = a; j < b; j++)
                {
                    val += amplSp[j] * Math.Cos(2 * Math.PI * i * j / n - phaseSp[j]);
                }
                values[i] = val;
            }
            return values;
        }

        internal double[] RestoreNFSignal()
        {
            double[] values = new double[n];
            for (int i = 0; i <= n - 1; i++)
            {
                double val = 0;
                for (int j = 0; j <= numHarm - 1; j++)
                {
                    val += amplSp[j] * Math.Cos(2 * Math.PI * i * j / n);
                }
                values[i] = val;
            }
            return values;
        }
    }
}

