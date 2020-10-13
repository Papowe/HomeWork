using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); 
            //где m — масса тела в килограммах, h — рост в метрах.

            double h, m, i;

            Console.Write("Ваш Рост: ");
            h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ваш Вес: ");
            m = Convert.ToDouble(Console.ReadLine());

            i = m / (h * h);

            Console.WriteLine($"Ваш индек массы тела: {i:F2}");


        }
    }
}
