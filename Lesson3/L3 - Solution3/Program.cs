using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3___Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел.
            // Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
            // Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи.Все программы сделать в одном решении.

            // **Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение
            // ArgumentException("Знаменатель не может быть равен 0");
            // Добавить упрощение дробей.

            RationalNumber a = new RationalNumber(4, 3);
            RationalNumber b = new RationalNumber(1, 2);

            RationalNumber rezAdding = RationalNumber.Adding(a, b);
            Console.WriteLine(rezAdding.ToString());

            RationalNumber rezSubtraction = RationalNumber.Subtraction(a, b);
            Console.WriteLine(rezSubtraction.ToString());

            RationalNumber rezMultiplication = RationalNumber.Multiplication(a, b);
            Console.WriteLine(rezMultiplication.ToString());

            RationalNumber rezDivision = RationalNumber.Division(a, b);
            Console.WriteLine(rezDivision.ToString());


        }
    }
}
