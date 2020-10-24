using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5___Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
                    //2.Разработать класс Message, содержащий следующие статические методы для обработки текста:
                    //а) Вывести только те слова сообщения, которые содержат не более n букв.
                    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
                    //в) Найти самое длинное слово сообщения.
                    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
                    //Продемонстрируйте работу программы на текстовом файле с вашей программой.

            string line = File.ReadAllText("text.txt");

            Console.WriteLine(line);
            Console.WriteLine();

            string processedString = Message.NumberOfLetters(line, 5);
            Console.WriteLine(processedString);
            Console.WriteLine();

            processedString = Message.DeleteWords(line, 'й');
            Console.WriteLine(processedString);
            Console.WriteLine();

            processedString = Message.LongWord(line);
            Console.WriteLine(processedString);
            Console.WriteLine();

            StringBuilder sb = Message.AllLongWord(line);
            Console.WriteLine(sb);

        }
    }
}
