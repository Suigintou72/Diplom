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

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Authentication.xaml
    /// </summary>
    public partial class Authentication : Window
    {

        private MainWindow mw;
        private Admin adm;

        public Authentication()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        //Получение запроса(текст на поле) на кнопку с PasswordBox
        public string Password
        {
            get { return passwordBox.Text; }
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {

                if (passwordBox.Text == "1")
                {
                    ///MessageBox.Show("Авторизация пройдена");
                    adm = new Admin();
                    adm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                    passwordBox.Clear();
                }
        }

        //Нажать на Ентер в поле ввода пароля
        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (passwordBox.Text == "1" & e.Key == Key.Enter)
            {
                ///MessageBox.Show("Авторизация пройдена");
                adm = new Admin();
                adm.Show();
                this.Close();
            }

        }
    }
}
