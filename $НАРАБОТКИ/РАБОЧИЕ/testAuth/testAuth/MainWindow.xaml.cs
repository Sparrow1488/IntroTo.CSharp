using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MetaData.client = new FirebaseClient(MetaData.config);
            if (MetaData.client == null)
            {
                ExceptionBlock("Ошибка подключения к серверу");
            }
            else
            {
                exceptionText.Visibility = Visibility.Hidden;
            }
        }
        private async void authBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await GetInfo();
            }
            catch (Exception ex)
            {
                ExceptionBlock(ex.Message);
            }
        }
        private async Task GetInfo()
        {
            exceptionText.Visibility = Visibility.Visible;
            exceptionText.Text = "Пожалуйста, подождите...";
            exceptionText.Foreground = new SolidColorBrush(Colors.Blue);
            string treatLogin = loginTB.Text;
            string treatPassword = passTB.Password;
            await Task.Run(() =>
            {
                CheckAbsentPasOrLog(treatLogin, treatPassword);
                if (CheckUniqueUser(treatLogin).Result)
                {
                    MyUser.ActiveUser = new MyUser(treatLogin, treatPassword);
                    MetaData.client.SetAsync(MetaData.parentPath + "/" + MyUser.ActiveUser.Login, MyUser.ActiveUser);
                    MessageBox.Show(MyUser.ActiveUser.Login);
                }
                else
                {
                    throw new ArgumentException("Такой пользователь уже существует!");
                }
            });
            exceptionText.Visibility = Visibility.Hidden;
        }
        private void loginTB_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            exceptionText.Visibility = Visibility.Hidden;
        }

        #region MoreMethods
        private async Task<bool> CheckUniqueUser(string login)
        {
            var response = await MetaData.client.GetAsync($"{MetaData.parentPath}/{login}");
            var getUser = response.ResultAs<MyUser>();
            if (getUser == null)
            {
                return true;
            }
            else return false;
        }
        private void ExceptionBlock(string exception)
        {
            exceptionText.Foreground = new SolidColorBrush(Colors.Red);
            exceptionText.Visibility = Visibility.Visible;
            exceptionText.Text = exception;
        }
        private bool CheckAbsentPasOrLog(string log, string pas)
        {
            if (string.IsNullOrWhiteSpace(log))
            {
                throw new ArgumentException("Заполните логин");
            }
            if (string.IsNullOrWhiteSpace(pas))
            {
                throw new ArgumentException("Заполните пароль");
            }
            return true;
        }
        #endregion

    }
}
