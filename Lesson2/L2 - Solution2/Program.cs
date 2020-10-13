using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Solution2
{
    class Program
    {
        // Написать метод подсчета количества цифр числа.


        static void Main(string[] args)
        {
            CoutnNumbers(522);
        }

        static void CoutnNumbers(int a)
        {
            int i;
            for (i = 0; a!= 0; i++)
            {
                a = a / 10;
            }
            Console.WriteLine("Количиство чисел = " + i.ToString());
        }
    }
}
