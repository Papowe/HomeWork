using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace L5___Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, 
            // содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            // а) без использования регулярных выражений;
            // б) **с использованием регулярных выражений.

            bool confirm = false;

            while (!confirm)
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                //confirm = LoginVerification(login);
                confirm = LoginVerification(login, true);                
            }

            Console.WriteLine("Вы вошли");

        }

        /// <summary>
        /// Проверяет корректность логина, без использования регулярных выражений.
        /// </summary>
        /// <param name="str">Логин</param>
        /// <returns>Возврат true если является корректным логином.</returns>
        static bool LoginVerification(string str)
        {
            if (str.Length > 2 && str.Length < 10)
            {
                if (!char.IsDigit(str[0]))
                {
                    bool check = true;

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (!(char.IsDigit(str[i]) || IsLatinLeater(str[i])))
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        Console.WriteLine("Корректно введенный логин!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Логин некорректный!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Логин не должен начинаться с цифры!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Логин должен быть от 2 до 10 символов!");
                return false;
            }
        }

        /// <summary>
        /// Проверяет корректность логина, с использованием регулярных выражений.
        /// </summary>
        /// <param name="str">Логин</param>
        /// <param name="regular">Затычка для перегрузки метода</param>
        /// <returns>Возврат true если является корректным логином.</returns>
        static bool LoginVerification(string str, bool regular)
        {
            bool check = false;
            Regex regex = new Regex(@"\b[a-zA-Z][a-zA-z0-9]{2,9}\b");
            check = regex.IsMatch(str);
            if (check)
            {
                Console.WriteLine("Корректно введенный логин!");
                return true;
            }
            else
            {
                Console.WriteLine("Логин некорректный!");
                return false;
            }
            
        }


        /// <summary>
        /// Метод проверяет символ, является ли он латинской буквой.
        /// </summary>
        /// <param name="leater">Символ</param>
        /// <returns>Возврат true если является латинской буквой.</returns>
        static bool IsLatinLeater(char leater)
        {
            if (leater >= 'a' && leater <= 'z' ||
                leater >= 'A' && leater <= 'Z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
