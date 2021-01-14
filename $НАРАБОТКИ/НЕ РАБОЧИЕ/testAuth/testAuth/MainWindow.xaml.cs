using System;
using System.Windows;
using FireSharp;
using testAuth.Classes;

namespace testAuth
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void authBtn_Click(object sender, RoutedEventArgs e)
        {
            exceptionText.Visibility = Visibility.Hidden;
            string treatLogin = loginTB.Text;
            string treatPassword = passTB.Password;
            IsAbsentPasOrLog(treatLogin, treatPassword);

            var user = new MyUser(treatLogin, treatPassword);


        }
        private void IsAbsentPasOrLog(string log, string pas)
        {
            if (string.IsNullOrWhiteSpace(log))
            {
                exceptionText.Visibility = Visibility.Visible;
                exceptionText.Text = "Заполните логин";
            }
            if (string.IsNullOrWhiteSpace(pas))
            {
                exceptionText.Visibility = Visibility.Visible;
                exceptionText.Text = "Заполните пароль";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MetaData.client = new FirebaseClient(MetaData.config);
            if(MetaData.client == null)
            {
                exceptionText.Visibility = Visibility.Visible;
                exceptionText.Text = "Ошибка подключения к серверу";
            }
            else
            {
                exceptionText.Visibility = Visibility.Hidden;
            }
        }

        private void loginTB_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            exceptionText.Visibility = Visibility.Hidden;
        }
        private MyUser CheckUniqueUser()
        {

        }
    }
}
