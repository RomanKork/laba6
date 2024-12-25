using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    // Интерфейс для дробей
    public interface IFraction
    {
        int Numerator { get; set; }
        int Denominator { get; set; }
        double Value();
    }
}
