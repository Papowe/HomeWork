using System;
using System.Collections.Generic;
using System.IO;

namespace L6___Solution2
{
    class Program
    {
        public delegate double Fun(double x);
        static void Main(string[] args)
        {
            // Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            // а) Сделать меню с различными функциями и представить пользователю выбор, 
            // для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
            // б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
            // Пусть она возвращает минимум через параметр(с использованием модификатора out

            List<Fun> funs = new List<Fun> { new Fun(F), 
                                             new Fun(Square), 
                                             new Fun(MySin), 
                                             new Fun(MySqrt), 
                                             new Fun(Cube) };

            Console.WriteLine("Выберете функцию :\n" +
                "1. x * x - 50 * x + 10\n" +
                "2. х в степени 2\n" +
                "3. Синус х\n" +
                "4. Квадратный корень х\n" +
                "5. х в кубе");

            bool flag = int.TryParse(Console.ReadLine(), out int choise);

            if (flag && choise >= 1 && choise <= 5)
            {
                Console.Write("Введите начало отрезка: ");
                int startLine = int.Parse(Console.ReadLine());
                Console.Write("Введите конец отрезка: ");
                int endLine = int.Parse(Console.ReadLine());
                Console.Write("Введите шаг: ");
                int step = int.Parse(Console.ReadLine());

                if (startLine < endLine)
                {
                    SaveFunc("data.bin", funs[choise - 1], startLine, endLine, step);
                    List<double> listValueFunction = Load("data.bin", out double minvalueFunction);
                    Console.WriteLine($"Минимальное значение функции : {minvalueFunction}");
                    PrintResults(startLine, endLine, step, listValueFunction);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Начало должно быть меньше конца");
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }

        }

        /// <summary>
        /// Функция x * x - 50 * x + 10
        /// </summary>
        /// <param name="x">x</param>
        /// <returns></returns>
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        /// <summary>
        /// Функция х в квадрате
        /// </summary>
        /// <param name="x">х</param>
        /// <returns></returns>
        public static double Square(double x)
        {
            return Math.Pow(x, 2);
        }

        /// <summary>
        /// Синус х.
        /// </summary>
        /// <param name="x">х</param>
        /// <returns></returns>
        public static double MySin(double x)
        {
            return Math.Sin(x);
        }

        /// <summary>
        /// Функция х в кубе
        /// </summary>
        /// <param name="x">х</param>
        /// <returns></returns>
        public static double Cube(double x)
        {
            return Math.Pow(x, 3);
        }

        /// <summary>
        /// Корень х
        /// </summary>
        /// <param name="x">х</param>
        /// <returns></returns>
        public static double MySqrt(double x)
        {
            return Math.Sqrt(x);
        }

        /// <summary>
        /// Метод передает функцию и записывает результат в файл.
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <param name="fun">Функция</param>
        /// <param name="a">Начало отрезка</param>
        /// <param name="b">Конец отрезка</param>
        /// <param name="h">Шаг</param>
        public static void SaveFunc(string fileName,Fun fun, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;            
            while (x <= b)
            {                
                bw.Write(fun(x));
                x += h;
            }            
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Находит минимальное значение функции.
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <returns></returns>
        public static List<double> Load(string fileName, out double m)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            List<double> listListValues = new List<double>();
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                listListValues.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            m = min;
            return listListValues;
        }

        /// <summary>
        /// Метод выводит на экран значение функции и её аргумента
        /// </summary>
        /// <param name="start">Начальное значенеи аргумента</param>
        /// <param name="end">Конечное значение аргумента</param>
        /// <param name="step">Шаг дискредитирования</param>
        /// <param name="values">Массив значений функции</param>
        static void PrintResults(double start, double end, double step, List<double> values)
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }
    }
}

