using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryWork1.ViewModels
{
    public class Formula
    {
        public double B1 { get; set; }
        public double B2 { get; set; }
        public int N { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
        public IFormFile Photo { get; set; }
        public int Divider { get; set; }
        public int[] Inputs { get; set; }
        public int Radio1 { get; set; }
        public int Radio { get; set; }
        public bool Substract { get; set; }
    }    
}
