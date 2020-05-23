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
    /// Логика взаимодействия для Level2_3.xaml
    /// </summary>
    public partial class Level2_3 : Window
    {

        private GameNum.Level3.Level3 lv3;

        public Level2_3()
        {
            InitializeComponent();
        }

        ///Событие по кнопке
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "2")
            {
                MessageBox.Show("Поздравляю, вы прошли второй уровень! Переход к последнему уровню.");
                MessageBox.Show("ПРИМЕЧАНИЕ: Данная фигура называется ТРАПЕЦИЯ. Запомни, это важно!");
                lv3 = new GameNum.Level3.Level3();
                lv3.Show();
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
                if (textBox1.Text == "2")
                {
                    MessageBox.Show("Поздравляю, вы прошли второй уровень! Переход к последнему уровню.");
                    MessageBox.Show("ПРИМЕЧАНИЕ: Данная фигура называется ТРАПЕЦИЯ. Запомни, это важно!");
                    lv3 = new GameNum.Level3.Level3();
                    lv3.Show();
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
