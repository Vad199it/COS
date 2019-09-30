using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryWork1.ViewModels
{
    public class Formula
    {
        public double Frequency { get; set; }
        public double InitialPhase { get; set; }
        public double Amplitude { get; set; }
        public int N { get; set; }
        public bool Noise { get; set; }
        public bool Polyharmonic { get; set; }
        public int RadioButton { get; set; }
    }
}
