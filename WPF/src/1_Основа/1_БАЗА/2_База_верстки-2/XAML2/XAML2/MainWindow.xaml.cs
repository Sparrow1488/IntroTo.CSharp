using System;
using System.Windows;
using System.Windows.Media;

namespace XAML2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person person = new Person("Vova", "Dmitriew", 14);
            Title = person.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtB2.Text.Equals("pizza"))
                txtB_Pizza.Visibility = Visibility.Visible;
            if (txtB_Pizza.Visibility == Visibility.Visible)
            {
                mainBtn.Content = "Write 'next'";
                if (txtB_Pizza.Text.Equals("next"))
                    colorPanel.Visibility = Visibility.Visible;
            }
        }

        private void btnSetColor_Click(object sender, RoutedEventArgs e)
        {

            if (radioBtnBlue.IsChecked == true)
                contentGrid.Background = new SolidColorBrush(Colors.DarkBlue);
            else if(radioBtnGreen.IsChecked == true)
                contentGrid.Background = new SolidColorBrush(Colors.ForestGreen);
            else if (radioBtnRed.IsChecked == true)
                contentGrid.Background = new SolidColorBrush(Colors.Firebrick);
        }
    }
}
