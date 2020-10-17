using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3___Solution1
{
    class ClassComplex
    {
        public double im;
        public double re;

        public ClassComplex Plus(ClassComplex x)
        {
            ClassComplex y = new ClassComplex();
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public ClassComplex Minus(ClassComplex x)
        {
            ClassComplex y = new ClassComplex();
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public ClassComplex Milti(ClassComplex x)
        {
            ClassComplex y = new ClassComplex();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
