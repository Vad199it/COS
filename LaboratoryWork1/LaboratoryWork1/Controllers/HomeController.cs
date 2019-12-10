using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LaboratoryWork1.Models;
using LaboratoryWork1.ViewModels;
using LaboratoryWork1.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace LaboratoryWork1.Controllers
{
    public class HomeController : Controller
    {
        IHostingEnvironment hostingEnvironment;
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ImageLoading(Formula formula)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (formula.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = "image.jpg";
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    FileStream stream = new FileStream(filePath, FileMode.Create);
                    formula.Photo.CopyTo(stream);
                    stream.Close();

                }
                Photo photo = new Photo
                {
                    photoPath = uniqueFileName
                };
            }
            return View();
        }

        private int[,] ReadKernelValues(Formula formula)
        {
            int kernelSize = formula.Radio; 

            int[,] kernel = new int[kernelSize, kernelSize];
            //{
            //    { 1, 2, 1 },
            //    { 2, 3, 2 },
            //    { 1, 2, 1 }
            //  };
            int k = 0;

            for (int i = 0; i < kernelSize; i++)
            {
                for (int j = 0; j < kernelSize; j++)
                {
                    kernel[i, j] = formula.Inputs[k];
                    k++;
                }
            }

            return kernel;
        }

        private int ReadDividerValue(Formula formula)
        {
            return formula.Divider;
        }

        [HttpGet]
        public void Convertion(Formula formula)
        {
            FileStream imgPathfs = new FileStream("wwwroot/images/image.jpg", FileMode.Open, FileAccess.Read);
            Bitmap sourceBmp = new Bitmap(Image.FromStream(imgPathfs, true, false));
            imgPathfs.Close();
            int[,] kernel;
            int divider;
            string uniqueFileName = null;

            kernel = ReadKernelValues(formula);
            divider = ReadDividerValue(formula);       
            Bitmap filteredBmp = Convolution.ApplyFilter(sourceBmp, kernel, divider, (FilterMode)formula.Radio1, formula.Substract);
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
            uniqueFileName = "result.jpg";
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            FileStream str = new FileStream(filePath, FileMode.Create);
            filteredBmp.Save(str, ImageFormat.Jpeg);
            str.Close();
        }

        [HttpGet]
        public (double[], double[], double[], double[], double[], double[]) AxisY(Formula formula)
        {
            var signal = new NoisySignal(formula.B1, formula.B2, formula.N);
            var parabolicSmoothedSignal = signal.ParabolicSmooth(signal.SignalVal);
            var medianFilteringSmoothedSignal = signal.MedianFilteringSmoothing(signal.SignalVal, 5);
            var medianAverageFilteringSmoothedSignal = signal.MedianAverageFilteringSmoothing(signal.SignalVal, 3);
            var Sine = signal.GetSineSpectrum(parabolicSmoothedSignal);
            var Cosine = signal.GetCosineSpectrum(parabolicSmoothedSignal);
            var Ampl = signal.GetAmplSpectrum(Sine, Cosine);
            var Phase = signal.GetPhaseSpectrum(Sine, Cosine);
            var Sine1 = signal.GetSineSpectrum(signal.SignalVal);
            var Cosine1 = signal.GetCosineSpectrum(signal.SignalVal);
            var Ampl1 = signal.GetAmplSpectrum(Sine1, Cosine1);
            var Phase1 = signal.GetPhaseSpectrum(Sine1, Cosine1);
            var Sine2 = signal.GetSineSpectrum(medianFilteringSmoothedSignal);
            var Cosine2 = signal.GetCosineSpectrum(medianFilteringSmoothedSignal);
            var Ampl2 = signal.GetAmplSpectrum(Sine2, Cosine2);
            var Phase2 = signal.GetPhaseSpectrum(Sine2, Cosine2);
            var Sine3 = signal.GetSineSpectrum(medianAverageFilteringSmoothedSignal);
            var Cosine3 = signal.GetCosineSpectrum(medianAverageFilteringSmoothedSignal);
            var Ampl3 = signal.GetAmplSpectrum(Sine3, Cosine3);
            var Phase3 = signal.GetPhaseSpectrum(Sine3, Cosine3);
            if (formula.Check1)
                return (signal.SignalVal, medianAverageFilteringSmoothedSignal, Ampl1, Ampl3, Phase1, Phase3);
            if (formula.Check2)
                return (signal.SignalVal, parabolicSmoothedSignal, Ampl1, Ampl, Phase1, Phase);
           
            return (signal.SignalVal, medianFilteringSmoothedSignal, Ampl1, Ampl2, Phase1, Phase2);
        }


        [HttpGet]
        public int[] AxisX(int N)
        {
            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
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
