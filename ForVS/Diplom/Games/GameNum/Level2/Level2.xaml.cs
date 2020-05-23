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

namespace Diplom.Games.GameNum.Level2
{
    /// <summary>
    /// Логика взаимодействия для Level2.xaml
    /// </summary>
    public partial class Level2 : Window
    {

        private GameNum.Level2.Level2_2 lv2_2;

        public Level2()
        {
            InitializeComponent();
        }

        ///Событие по кнопке
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "5")
            {
                MessageBox.Show("Правильно! Следующее задание.");
                lv2_2 = new GameNum.Level2.Level2_2();
                lv2_2.Show();
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
                if (textBox1.Text == "5")
                {
                    MessageBox.Show("Правильно! Следующее задание.");
                    lv2_2 = new GameNum.Level2.Level2_2();
                    lv2_2.Show();
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
