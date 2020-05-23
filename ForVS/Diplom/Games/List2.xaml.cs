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
    /// Логика взаимодействия для List2.xaml
    /// </summary>
    public partial class List2 : Window
    {

        private GamePod.Level1.Level1 lv1;
        private GamePod.Level2.Level2 lv2;

        public List2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lv1 = new GamePod.Level1.Level1();
            lv1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lv2 = new GamePod.Level2.Level2();
            lv2.Show();
        }
    }
}
