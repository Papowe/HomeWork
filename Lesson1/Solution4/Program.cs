using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            int a, b, temp;

            Console.Write("Введите первое число a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число b = ");
            b = Convert.ToInt32(Console.ReadLine());

            //-----------------ПЕРВЫЙ СПОСОБ----------------
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a = {a}, b = {b}");

            //----------------ВТОРОЙ СПОСОБ------------------
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a = {a}, b = {b}");


        }
    }
}
