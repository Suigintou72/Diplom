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

namespace Diplom.Games.GamePod.Level1
{
    /// <summary>
    /// Логика взаимодействия для Level1.xaml
    /// </summary>
    public partial class Level1 : Window
    {

        private Level1_2 lv1_2;

        public Level1()
        {
            InitializeComponent();
        }

        ///Событие по кнопке
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "3")
            {
                MessageBox.Show("Правильно! Следующее задание.");
                lv1_2 = new Level1_2();
                lv1_2.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Ответ неверный.");
                textBox1.Clear();
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (textBox1.Text == "3")
                {
                    MessageBox.Show("Правильно! Следующее задание.");
                    lv1_2 = new Level1_2();
                    lv1_2.Show();
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
