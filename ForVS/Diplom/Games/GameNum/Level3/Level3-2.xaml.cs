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
    /// Логика взаимодействия для Level3_2.xaml
    /// </summary>
    public partial class Level3_2 : Window
    {

        private GameNum.Level3.Level3_3 lv3_3;

        public Level3_2()
        {
            InitializeComponent();
        }

        ///Событие по кнопке
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "4")
            {
                MessageBox.Show("Правильно! Следующее задание.");
                lv3_3 = new GameNum.Level3.Level3_3();
                lv3_3.Show();
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
                if (textBox1.Text == "4")
                {
                    MessageBox.Show("Правильно! Следующее задание.");
                    lv3_3 = new GameNum.Level3.Level3_3();
                    lv3_3.Show();
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
