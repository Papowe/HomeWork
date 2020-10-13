using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Splution3
{
    class Program
    {

        // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Main(string[] args)
        {
            int a;
            int sum = 0;

            do
            {
                Console.WriteLine("Введите число");
                a = int.Parse(Console.ReadLine());
                sum += a;

            }
            while (a != 0);

            Console.WriteLine("Сумма введенных цифр = " + sum.ToString());
        }
    }
}
