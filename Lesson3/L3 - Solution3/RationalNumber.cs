using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3___Solution3
{
    class RationalNumber
    {
        private int numerator;
        private int denominator;

        public RationalNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
        }
        public RationalNumber()
        {
        }

        public static RationalNumber Adding(RationalNumber firstRationalNumber, RationalNumber secondRationalNumber)
        {
            RationalNumber r = new RationalNumber();
            r.numerator = (firstRationalNumber.numerator * secondRationalNumber.denominator) + (firstRationalNumber.denominator * secondRationalNumber.numerator);
            r.denominator = firstRationalNumber.denominator * secondRationalNumber.denominator;
            return r;
        }        
        
        public static RationalNumber Subtraction(RationalNumber firstRationalNumber, RationalNumber secondRationalNumber)
        {
            RationalNumber r = new RationalNumber();
            r.numerator = (firstRationalNumber.numerator * secondRationalNumber.denominator) - (firstRationalNumber.denominator * secondRationalNumber.numerator);
            r.denominator = firstRationalNumber.denominator * secondRationalNumber.denominator;
            return r;
        }

        public static RationalNumber Multiplication(RationalNumber firstRationalNumber, RationalNumber secondRationalNumber)
        {
            RationalNumber r = new RationalNumber();
            r.numerator = firstRationalNumber.numerator * secondRationalNumber.numerator;
            r.denominator = firstRationalNumber.denominator * secondRationalNumber.denominator;
            return r;
        }

        public static RationalNumber Division(RationalNumber firstRationalNumber, RationalNumber secondRationalNumber)
        {
            RationalNumber r = new RationalNumber();
            r.numerator = firstRationalNumber.numerator * secondRationalNumber.denominator;
            r.denominator = firstRationalNumber.denominator * secondRationalNumber.numerator;
            return r;
        }

        public override string ToString()
        {
            return $"n{numerator} d{denominator}";
        }
    }
}
