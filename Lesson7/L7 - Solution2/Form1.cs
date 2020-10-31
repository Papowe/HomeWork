using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L7___Solution2
{
        // Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, 
        // а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
        // a) Для ввода данных от человека используется элемент TextBox;
        // б) ** Реализовать отдельную форму c TextBox для ввода числа.


    public partial class Form1 : Form
    {
        private int secretNumber;
        private int count;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Записывает рандомное число в переменную и выводит сообщение.
            secretNumber = rnd.Next(1, 101);
            MessageBox.Show($"Компьютер загадал число от 1 до 100. попробуйте его отгадать. {secretNumber}");
        }

        private void enter_Click(object sender, EventArgs e)
        {
            // Проверка на пустоту поля
            if (txtNumber.Text != "")
            {
                bool isNumber = int.TryParse(txtNumber.Text, out int temp);
                
                //Проверка введено ли число
                if (isNumber)
                {
                    Counter();

                    if (temp < secretNumber) // Если число меньше выводит сообщение
                    {
                        lblInfoGame.Text = "Число меньше загаданного.";
                    }
                    else if (temp > secretNumber) // Если число больше выводит сообщение
                    {
                        lblInfoGame.Text = "Число больше загаданного.";
                    }
                    else if (temp == secretNumber) // Если число ровно выводит сообщение про победу и закрывает програму.
                    {
                        MessageBox.Show($"Вы победили. За {count} попыток.");
                        Close();
                    }
                }
                else
                {
                    lblInfoGame.Text = "Нужно вводить числа.";
                }
            }
            
        }

        /// <summary>
        /// Метод для подсчета попыток
        /// </summary>
        private void Counter()
        {
            count++;
            lblCount.Text = $"Попыток : {count}";
        }
    }
}
