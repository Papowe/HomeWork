using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution5
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.
            //в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Ваша Фамилия: ");
            string lastName = Console.ReadLine();
            Console.Write("Ваш город: ");
            string city = Console.ReadLine();

            string str = $"{name} {lastName}, Город - {city}";

            int x = (int)Console.WindowWidth / 2 - (str.Length / 2);
            int y = (int)Console.WindowHeight / 2;

            Print(str, x, y);
        }

        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);

        }
    }
}
