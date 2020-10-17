using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3___Solution1
{
    class Program
    {
        // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
        // б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

        // Гавран Михаил.

        static void Main(string[] args)
        {
            //----------------------ПРИМЕР КОМПЛЕКСНЫХ ЧИСЕЛ СТРУКТУР------------------
            StructComplex complex1;
            complex1.im = 34;
            complex1.re = 6;

            StructComplex complex2;
            complex2.im = 3;
            complex2.re = 2;

            StructComplex rezultComplex = complex1.Minus(complex2);
            Console.WriteLine(rezultComplex.ToString());

            //---------------------ПРИМЕР КОМПЛЕКСНЫХ ЧИСЕЛ КЛАССОВ-------------------
            ClassComplex complex3 = new ClassComplex();
            complex3.im = 10;
            complex3.re = 8;

            ClassComplex complex4 = new ClassComplex();
            complex3.im = 1;
            complex3.re = 4;

            ClassComplex rezultClass = complex3.Minus(complex4);
            Console.WriteLine(rezultClass.ToString());




        }
    }
}
