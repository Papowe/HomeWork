using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Реализовать метод проверки логина и пароля. 
            // На вход метода подается логин и пароль. 
            // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            // Используя метод проверки логина и пароля, написать программу: 
            // пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            // С помощью цикла do while ограничить ввод пароля тремя попытками.

            int i = 0;
            bool res;
            do
            {
                i++;
                Console.Write("Введите логин - ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль - ");
                string password = Console.ReadLine();
                res = SingIn(login, password);
            }
            while (i < 3 && !res);

            if (res)
            {
                Console.WriteLine("Программа выполняться");
            }
            else
            {
                Console.WriteLine("Программа не выполняться");
            }
        }

        static bool SingIn(string login, string password)
        {
            if (login == "1" && password == "2")
            {
                Console.WriteLine("Все верно!!!");
                return true;
            }
            else
            {
                Console.WriteLine("Неверно!!!");
                return false;
            }
        }
    }
}
