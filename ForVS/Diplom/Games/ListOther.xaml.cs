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

namespace Diplom.Games
{
    /// <summary>
    /// Логика взаимодействия для ListOther.xaml
    /// </summary>
    public partial class ListOther : Window
    {
        private Snake.Form1 frm1;
        private Tetris.MainWindow tet;

        public ListOther()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frm1 = new Snake.Form1();
            frm1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tet = new Tetris.MainWindow();
            tet.Show();
            MessageBox.Show("Фигуры Тетрис управляются при помощи стрелок на клавиатуре.");
        }
    }
}
