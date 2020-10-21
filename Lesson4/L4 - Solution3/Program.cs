using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4___Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            // а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, 
            // создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
            // Создать свойство Sum, которое возвращает сумму элементов массива, 
            // метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  
            // метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
            // б)**Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            // е) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)

            MyClass myClass = new MyClass(11, -13, 3);

            Console.WriteLine("Все  элементы вассива.");
            myClass.Show();

            Console.WriteLine($"Сумма всех числем массива = {myClass.Sum}");

            Console.WriteLine("Скопированный массив с измененными знаками.");
            int[] arr2 = new int[myClass.Length];
            arr2 = myClass.Inverse();
            foreach (var item in arr2)
            {
                Console.Write($"{item} ");
            }


            Console.WriteLine("\nУмножаем каждый элемент массива на определённое число");
            myClass.Multi(4);
            myClass.Show();

            Console.WriteLine($"Максимальный элемент массива = {myClass.MaxCount}");

        }
    }
}
