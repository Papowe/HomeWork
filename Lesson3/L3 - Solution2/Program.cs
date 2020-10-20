using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L3___Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            //а) С клавиатуры вводятся числа, пока не будет введен 0(каждое число в новой строке).
            //   Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;

            //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
            //   При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
            

            int sum = 0;
            int x;
            int count = 0;
            List<int> listNumber = new List<int>();

            Console.WriteLine("Введите числа. 0 останавливает программу.");                      

            while (true)
            {
                bool parsedSuccesfully = int.TryParse(Console.ReadLine(), out x);

                if (parsedSuccesfully)
                {
                    if (x % 2 != 0 && x > 0)
                    {
                        count++;
                        sum += x;
                        listNumber.Add(x);
                    }
                    else if (x == 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Нужно ввести число");
                    //throw new Exception("нужно ввести число");
                }
            }

            Console.WriteLine($"Сума всех нечетных положительных чисел = {sum}\nНечетных положительных чисел = {count}");

            Console.Write("Сами числа = ");
            foreach (int numbers in listNumber)
            {
                Console.Write($"{numbers}, ");
            }
        }
    }
}
