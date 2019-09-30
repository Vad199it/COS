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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public double[] AxisY(Formula formula)
        {
            switch (formula.RadioButton)
            {
                case 1:
                    return Formulas.Harmonic(formula);
                case 2:
                    return Formulas.Sinus(formula);
                case 3:
                    return Formulas.Square(formula);
                case 4:
                    return Formulas.Triangle(formula);
                case 5:
                    return Formulas.Sowtooth(formula);
                default:
                    return Formulas.Harmonic(formula);
            }
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
