using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace L2___Solution5
{
    class Program
    {
        static void Main(string[] args)
        {
            // а) Написать программу, которая запрашивает массу и рост человека, 
            // вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            double h, m, i;

            Console.Write("Ваш Рост: ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ваш Вес: ");
            m = Convert.ToDouble(Console.ReadLine());

            i = m / (Math.Pow(h, 2));

            Console.WriteLine($"Ваш индек массы тела: {i:F2}");

            if (i > 0 && i <= 18.5)
            {
                Console.WriteLine("Недостаточная (дефицит) масса тела, вам нужно поправиться");
            }
            else if (i > 18.5 && i <= 25)
            {
                Console.WriteLine("У вас нормальный вес");
            }
            else if (i > 25)
            {
                Console.WriteLine("Избыточная масса тела, вам нужно похудеть");
            }
            
        }
    }
}
