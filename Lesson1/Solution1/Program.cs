using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
            //В результате вся информация выводится в одну строчку:
            //а) используя склеивание;
            //б) используя форматированный вывод;
            //в) используя вывод со знаком $.

            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Ваша Фамилия: ");
            string lastName = Console.ReadLine();
            Console.Write("Ваш возвраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Ваш Рост: ");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ваш Вес: ");
            float weight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Имя - " + name + ", Фамилия - " + lastName + ", Возвраст - " + age + ", Рост - " + height + ", Вес - " + weight);
            Console.WriteLine("Имя - {0}, Фамилия - {1}, Возвраст - {2}, Рост - {3}, Вес - {4}", name, lastName, age, height, weight);
            Console.WriteLine($"Имя - {name}, Фамилия - {lastName}, Возвраст - {age}, Рост - {height}, Вес - {weight}");


        }
    }
}
