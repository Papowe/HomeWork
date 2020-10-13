using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая подсчитывает расстояние между точками с 
            //   координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //   Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //б) Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            double x1, x2, y1, y2, r;

            Console.Write("ВВедите точку x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВедите точку y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВедите точку x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ВВедите точку y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между точками: {r:F2}");

            DistanceBetweenPoints(4, 5, 6, 7);

            Console.ReadKey();
        }

        static void DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {   
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между точками: {r:F2}");
        }
    }
}
