using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4___Solution3
{
    class MyClass
    {
        private int[] arr;

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        /// <summary>
        /// Заполнение массива.
        /// </summary>
        /// <param name="elements">Количество элементов в массиве.</param>
        /// <param name="initial">Начальный элемент</param>
        /// <param name="step">Шаг с которым будет генерироваться массив.</param>

        public MyClass(int elements, int initial, int step)
        {
            arr = new int[elements];
            arr[0] = initial;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + step;
            }
        }

        /// <summary>
        /// Заполнение массива от 0 до заданого числа.
        /// </summary>
        /// <param name="element">количиство элементов</param>
        /// <param name="max">Максимальное число</param>
        public MyClass(int element, int max)
        {
            Random rnd = new Random();
            arr = new int[element];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(max);
            }
        }

        /// <summary>
        /// Возвращает максимальный элемент массива.
        /// </summary>
        public int Max
        {
            get
            {
                int max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max) max = arr[i];
                }
                return max;
            }
        }

        /// <summary>
        /// Возвращает количиство максимальныч элементов массива.
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == max) count++;
                }
                return count;
            }
        }

        /// <summary>
        /// Свойство возвращает сумму всех элементов массива.
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }

        /// <summary>
        /// Возвращает количество элементов массива.
        /// </summary>
        public int Length { get { return arr.Length; } }       

        /// <summary>
        /// Метод выводит в консоль элеиенты массива.
        /// </summary>
        public void Show()
        {
            foreach (int element in arr)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }       

        /// <summary>
        /// Метод копирует и возвращает массив с измененными знаками.
        /// </summary>
        /// <returns></returns>
        public int[] Inverse()
        {
            int[] tempArr = new int[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    tempArr[i] = arr[i];
            //    tempArr[i] = -tempArr[i];
            //}

            Array.Copy(arr, tempArr, arr.Length);
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = -tempArr[i];
            }

            return tempArr;
        }

        /// <summary>
        /// Умножает каждый элемент массива на определённое число.
        /// </summary>
        /// <param name="number">Множитель</param>
        public void Multi(int number)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= number;
            }
        }


    }
}
