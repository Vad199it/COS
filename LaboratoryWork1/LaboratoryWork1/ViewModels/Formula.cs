﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryWork1.ViewModels
{
    public class Formula
    {
        public double Frequency1 { get; set; }
        public double Frequency2 { get; set; }
        public double Frequency3 { get; set; }
        public double Frequency4 { get; set; }
        public double InitialPhase { get; set; }
        public double Amplitude1 { get; set; }
        public double Amplitude2 { get; set; }
        public double Amplitude3 { get; set; }
        public double Amplitude4 { get; set; }
        public int N { get; set; }
        public bool Noise { get; set; }
        public bool Line { get; set; }
        public int RadioButton { get; set; }
    }
}
