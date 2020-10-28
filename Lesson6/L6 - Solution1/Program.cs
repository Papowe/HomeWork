using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6___Solution1
{
    // Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
    // Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
   
    public delegate double Fun(double a, double x);

    class Program
    {
        static void Main()
        {
            Table(MyFunc, 3, -2, 2);
            Table(MyFunc2, 3, -2, 2);
        }

        // Создаем метод, который принимает делегат 
        public static void Table(Fun F,double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double a, double x)
        {
            return a * Math.Pow(x, 2);
        }

        // Создаем второй метод для передачи его в качестве параметра в Table
        public static double MyFunc2(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
