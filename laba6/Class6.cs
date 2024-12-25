using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    // Класс Дробь
    public class Fraction : IFraction, ICloneable
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get => _numerator;
            set { _numerator = value; Simplify(); }
        }

        public int Denominator
        {
            get => _denominator;
            set
            {
                if (value == 0)
                    throw new DivideByZeroException("Знаменатель не может быть равен нулю");

                if (value < 0)
                {
                    _numerator *= -1;
                    value *= -1;
                }

                _denominator = value;
                Simplify();
            }
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Знаменатель не может быть равен нулю");

            _numerator = numerator;
            Denominator = denominator;
        }

        private void Simplify()
        {
            int gcd = GCD(Math.Abs(_numerator), _denominator);
            _numerator /= gcd;
            _denominator /= gcd;
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public double Value() => (double)_numerator / _denominator;

        public object Clone() => new Fraction(_numerator, _denominator);

        public override string ToString() => $"{_numerator}/{_denominator}";

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int lcm = LCM(a._denominator, b._denominator);
            int numerator = a._numerator * (lcm / a._denominator) + b._numerator * (lcm / b._denominator);
            return new Fraction(numerator, lcm);
        }

        public static Fraction operator -(Fraction a, Fraction b) => a + new Fraction(-b._numerator, b._denominator);

        public static Fraction operator -(Fraction a, int b) => a + new Fraction(-b * a._denominator, a._denominator);

        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a._numerator * b._numerator, a._denominator * b._denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b._numerator == 0)
                throw new DivideByZeroException("Деление на ноль");

            return new Fraction(a._numerator * b._denominator, a._denominator * b._numerator);
        }

        private static int LCM(int a, int b) => (a * b) / GCD(a, b);

        public static bool operator ==(Fraction a, Fraction b)
        {
            return (a._numerator == b._numerator) && (a._denominator == b._denominator);
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
    }
}
