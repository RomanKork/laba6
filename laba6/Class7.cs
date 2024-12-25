using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    // Класс для дробей с кэшированием значения
    public class DoubleFraction : IFraction
    {
        private readonly Fraction _fraction;
        private double? _cachedValue;

        public DoubleFraction(Fraction fraction)
        {
            _fraction = fraction;
        }

        public int Numerator
        {
            get => _fraction.Numerator;
            set
            {
                _fraction.Numerator = value;
                _cachedValue = null;
            }
        }

        public int Denominator
        {
            get => _fraction.Denominator;
            set
            {
                _fraction.Denominator = value;
                _cachedValue = null;
            }
        }

        public double Value()
        {
            if (!_cachedValue.HasValue)
                _cachedValue = _fraction.Value();

            return _cachedValue.Value;
        }
    }
}
