using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5___Solution2
{
    static class Message
    {
        /// <summary>
        /// Метод выводит все слова с n количеством букв из строки.
        /// </summary>
        /// <param name="line">Строка</param>
        /// <param name="n">Количиство букв</param>
        public static string NumberOfLetters(string line, int n)
        {
            string tempLine = "";
            string[] str = line.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t', ':'});

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length == n)
                {
                    tempLine += $"{str[i]} "; 
                }
            }
            return tempLine;
        }

        /// <summary>
        /// Метод удаляет из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="line">Строка</param>
        /// <param name="c">Последний символ</param>
        /// <returns></returns>
        public static string DeleteWords(string line, char c)
        {
            string tempLine = "";

            string[] str = line.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t', ':'});

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "")
                {
                    if (str[i][str[i].Length - 1] != c)
                    {
                        tempLine += $"{str[i]} ";
                    }
                }
            }

            return tempLine;
        }

        /// <summary>
        /// Выводит самое длинное слово в строке.
        /// </summary>
        /// <param name="line">Строка</param>
        /// <returns>Возвращает длину самого длинного слова в строке..</returns>
        public static string LongWord(string line)
        {
            string tempLine = "";
            int maxWord = 0;

            string[] str = line.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t', ':' });

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "")
                {
                    if (str[i].Length > maxWord)
                    {
                        maxWord = str[i].Length;
                        tempLine = str[i];
                    }
                }
            }   

            return tempLine;
        }
        
        /// <summary>
        /// Формирует строку из самых длинных слов в тексте.
        /// </summary>
        /// <param name="line">Строка</param>
        /// <returns></returns>
        public static StringBuilder AllLongWord(string line)
        {
            StringBuilder sb = new StringBuilder();
            int maxWord = LongWord(line).Length;

            string[] str = line.Split(new Char[] { ' ', ',', '.', '-', '\n', '\t', ':' });

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "")
                {
                    if (str[i].Length == maxWord)
                    {
                        sb.Append(str[i].ToUpper() + " ");
                    }
                }
            }
            return sb;
        }
    }
}
