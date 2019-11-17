using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LaboratoryWork1.Models;
using LaboratoryWork1.ViewModels;
using LaboratoryWork1.Classes;

namespace LaboratoryWork1.Controllers
{
    public class HomeController : Controller
    {
        public const int HarmonicCount = 30;
        public const int N = 128;

        public double[] _signal;
        public double[] _recoveredSignal;
        public double[] _amplitudeSpectrum;
        public double[] _phaseSpectrum;

        public double[] _polyharmonicSignal;
        public double[] _polyharmonicRecoveredSignal;
        public double[] _polyharmonicRecoveredSignalWithoutPhase;
        public double[] _polyharmonicAmplitudeSpectrum;
        public double[] _polyharmonicPhaseSpectrum;

        public int[] _amplitudes = new[] { 1, 3, 5, 8, 10, 12, 16 };
        public double[] _phases = new[] { Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, 3 * Math.PI / 4, Math.PI };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public (double[], double[], double[], double[]) AxisY(Formula formula)
        {
            var hs = new HarmonicSignal(formula.Amplitude, formula.Frequency, formula.InitialPhase, formula.N);
            _signal = hs.signVal;
            _recoveredSignal = hs.restoredSignal;
            _amplitudeSpectrum = hs.amplSp;
            _phaseSpectrum = hs.phaseSp;

            var phs = new PolyharmonicSignal(_amplitudes, formula.Frequency, _phases, formula.N);
            _polyharmonicSignal = phs.signVal;
            _polyharmonicRecoveredSignal = phs.restoredSignal;
            _polyharmonicRecoveredSignalWithoutPhase = phs.restorednonphasedSignal;
            _polyharmonicAmplitudeSpectrum = phs.amplSp;
            _polyharmonicPhaseSpectrum = phs.phaseSp;

            switch (formula.RadioButton)
            {
                case 1:
                    return (_signal, _amplitudeSpectrum, _phaseSpectrum, _recoveredSignal);
                case 2:
                    return (_polyharmonicSignal, _polyharmonicAmplitudeSpectrum, _polyharmonicPhaseSpectrum, _polyharmonicRecoveredSignal);
                case 3:
                    return (_polyharmonicSignal, _polyharmonicAmplitudeSpectrum, _polyharmonicPhaseSpectrum, _polyharmonicRecoveredSignal);
                default:
                    return (_signal, _amplitudeSpectrum, _phaseSpectrum, _recoveredSignal);
            }
                                   
        }


        [HttpGet]
        public int[] AxisX(int N, int M)
        {
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + M;
            }
            return arr;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
