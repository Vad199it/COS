using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratoryWork1.Classes
{
    public enum FilterMode
    {
        ClampingOnly, // clamping value to 0..255 range
        AbsAndClamping, // apply Math.Abs(), then clamping to 0..255
        Add128AndClamping, // add 128, then clamping to 0..255
        Add128AbsAndClamping // add 128, then apply Math.Abs(), then clamping to 0..255
    }
}
