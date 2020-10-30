using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7___Solution1
{
    public partial class Form1 : Form
    {
        // а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
        // б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
        // Игрок должен получить это число за минимальное количество ходов.
        // в) *Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
        // Вся логика игры должна быть реализована в классе с удвоителем.
        
        /// <summary>
        /// Подсчет шагов
        /// </summary>
        int countCommand = 0;
        /// <summary>
        /// Стек для хранения истории чисел
        /// </summary>
        Stack<string> history = new Stack<string>();

        public Form1()
        {
            InitializeComponent();           
        }

        /// <summary>
        /// Кнопка добавляет 1 к числам и записывает в стек.
        /// </summary>
        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = (int.Parse(lblNumbers.Text) + 1).ToString();
            Counter(1);
            AddToHistory();
        }

        /// <summary>
        /// Кнопка умножает на 2 числа и записывает в стек.
        /// </summary>
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = (int.Parse(lblNumbers.Text) * 2).ToString();
            Counter(1);
            AddToHistory();
        }
        /// <summary>
        /// Кнопка все обнуляет
        /// </summary>
        private void btnCommand3_Click(object sender, EventArgs e)
        {
            lblNumbers.Text = "1";
            lblCount.Text = "Количества отданных команд : 0";
            countCommand = 0;

            for (int i = 0; i < history.Count; i++)
            {
                history.Pop();
            }
        }
       
        /// <summary>
        /// Кнопка отменяет последние действия
        /// </summary>
        private void cancel_Click(object sender, EventArgs e)
        {
            Counter(-1);
            Cancel();
        }
        /// <summary>
        /// Кнопка рандомно выберает сколько нужно набрать чилел и за сколько попыток
        /// </summary>
        private void MenuPlay_Click(object sender, EventArgs e)
        {
            Random rndNumer = new Random();
            Random rndAttempt = new Random();
            int attempt = rndAttempt.Next(5, 11);
            int number = rndNumer.Next(101);

            MessageBox.Show($"Наберите число : {number} за {attempt} попыток.");
        }
        /// <summary>
        /// Метод изменяет количичтво команд
        /// </summary>
        /// <param name="a">Можна добавить число к количиству команд, или отнять</param>
        private void Counter(int a)
        {
            countCommand += a;
            if (countCommand < 0)
            {
                countCommand = 0;
            }
            lblCount.Text = $"Количества отданных команд : {countCommand}";
        }

        /// <summary>
        /// Метод записывает номера в стек
        /// </summary>
        private void AddToHistory()
        {
            history.Push(lblNumbers.Text);            
        }

        /// <summary>
        /// Метод отменяет действия
        /// </summary>
        private void Cancel()
        {
            if (history.Count.Equals(0)) return;
            lblNumbers.Text = history.Pop();              
        }
    }
}
