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
            complex1.im = 10;
            complex1.re = 8;

            StructComplex complex2;
            complex2.im = 12;
            complex2.re = 3;

            StructComplex rezultComplexPlus = complex1.Plus(complex2);
            Console.WriteLine(rezultComplexPlus.ToString());

            StructComplex rezultComplexMinus = complex1.Minus(complex2);
            Console.WriteLine(rezultComplexMinus.ToString());

            //---------------------ПРИМЕР КОМПЛЕКСНЫХ ЧИСЕЛ КЛАССОВ-------------------
            ClassComplex complex3 = new ClassComplex();
            complex3.im = 10;
            complex3.re = 8;

            ClassComplex complex4 = new ClassComplex();
            complex4.im = 12;
            complex4.re = 3;

            ClassComplex rezultClassPlus = complex3.Plus(complex4);
            Console.WriteLine(rezultClassPlus.ToString());

            ClassComplex rezultClassMinus = complex3.Minus(complex4);
            Console.WriteLine(rezultClassMinus.ToString());

            ClassComplex rezultClassMUlti = complex3.Milti(complex4);
            Console.WriteLine(rezultClassMUlti.ToString());

        }
    }
}
