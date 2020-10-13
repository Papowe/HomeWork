using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L2___Solution1
{
    class Program
    {
        // Написать метод, возвращающий минимальное из трёх чисел.

        static void Main(string[] args)
        {
            Console.WriteLine(MinNumber(1, 56, 43));
        }

        static int MinNumber(int a, int b, int c)
        {
            if (a < b && a < c) return a;
            else if (b < c) return b;
            else return c;
        }
    }
}
