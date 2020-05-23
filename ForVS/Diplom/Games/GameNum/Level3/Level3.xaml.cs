using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Diplom.Games.GameNum.Level3
{
    /// <summary>
    /// Логика взаимодействия для Level3.xaml
    /// </summary>
    public partial class Level3 : Window
    {

        private GameNum.Level3.Level3_2 lv3_2;

        public Level3()
        {
            InitializeComponent();
        }

        ///Событие по кнопке
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "12")
            {
                MessageBox.Show("Правильно! Следующее задание.");
                lv3_2 = new GameNum.Level3.Level3_2();
                lv3_2.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Ответ неверный.");
                textBox1.Clear();
            }
        }

        ///Событие ввода по Ентер
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (textBox1.Text == "12")
                {
                    MessageBox.Show("Правильно! Следующее задание.");
                    lv3_2 = new GameNum.Level3.Level3_2();
                    lv3_2.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Ответ неверный.");
                    textBox1.Clear();
                }
            }
        }
    }
}
