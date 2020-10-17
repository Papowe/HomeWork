using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3___Solution1
{
    struct StructComplex
    {
        public double im;
        public double re;

        public StructComplex Plus(StructComplex x)
        {
            StructComplex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public StructComplex Minus(StructComplex x)
        {
            StructComplex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public StructComplex Milti(StructComplex x)
        {
            StructComplex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
