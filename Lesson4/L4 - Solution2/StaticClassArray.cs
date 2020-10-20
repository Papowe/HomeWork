using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4___Solution2
{
    static class StaticClassArray
    {
        /// <summary>
        /// Метод для заполнения массива случайными числами от –10 000 до 10 000 включительно.
        /// </summary>
        /// <param name="a">Массив</param>
        static public void ArrayPlaceholder(int[] a)
        {
            Random rnd = new Random();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-10_000, 10_001);
            }
        }
        /// <summary>
        /// Выводит количество пар элементов массива, в которых только одно число делится на 3.
        /// </summary>
        /// <param name="a">Массив</param>
        static public void SearchCouples(int[] a)
        {
            int count = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {

                if (a[i] % 3 == 0 || a[i + 1] % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Ответ = {count}");
        }

        /// <summary>
        /// Считывает массив из текстового файла. Метод возвращает массив целых чисел;
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns></returns>
        static public int[] ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                string[] ss = File.ReadAllLines(path);
                int[] tempIntarray = new int[ss.Length];

                for (int i = 0; i < ss.Length; i++)
                {
                    tempIntarray[i] = int.Parse(ss[i]);
                }

                return tempIntarray;
            }
            else
            {
                Console.WriteLine("Error load file");
                return new int[1] { 0 }; ;
            }
        }
    }
}
