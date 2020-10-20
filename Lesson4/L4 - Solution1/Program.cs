using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4___Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
            // Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
            // В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6; ответ — 2.

            int[] arr = new int[20];

            ArrayPlaceholder(arr);
            SearchCouples(arr);

            // простой вывод массива.
            foreach (int item in arr)
            {
                Console.Write($"{item}, ");
            }
        }
        /// <summary>
        /// Метод для заполнения массива случайными числами от –10 000 до 10 000 включительно.
        /// </summary>
        /// <param name="a">Массив</param>
        static void ArrayPlaceholder(int[] a)
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
        static void SearchCouples(int[] a)
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
    }
}
