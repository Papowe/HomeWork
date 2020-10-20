using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4___Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Реализуйте задачу 1 в виде статического класса StaticClass;
            // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            // б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            // в)**Добавьте обработку ситуации отсутствия файла на диске.

            int[] arr = new int[30];

            StaticClassArray.ArrayPlaceholder(arr);
            StaticClassArray.SearchCouples(arr);

            Console.WriteLine();

            int[] s;
            s = StaticClassArray.ReadFromFile("file.txt");
            foreach (var item in s)
            {
                Console.WriteLine(item);               
            }

        }
    }
}
