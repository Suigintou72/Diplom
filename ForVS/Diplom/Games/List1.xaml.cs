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
    /// Логика взаимодействия для List1.xaml
    /// </summary>
    public partial class List1 : Window
    {

        private GameNum.Level1 lv1;
        private GameNum.Level2.Level2 lv2;
        private GameNum.Level3.Level3 lv3;

        public List1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lv1 = new GameNum.Level1();
            lv1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lv2 = new GameNum.Level2.Level2();
            lv2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lv3 = new GameNum.Level3.Level3();
            lv3.Show();
        }
    }
}
