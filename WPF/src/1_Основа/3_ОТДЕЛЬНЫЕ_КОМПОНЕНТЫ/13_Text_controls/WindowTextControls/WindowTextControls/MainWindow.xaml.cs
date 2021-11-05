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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowTextControls
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            txtBlock1.Text = textBox.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //selectedTxtBox.SelectionStart = 2;
            //selectedTxtBox.SelectionLength = 10;
            //selectedTxtBox.Focus();

            //или 
            selectedTxtBox.Select(0, selectedTxtBox.Text.Length);
            selectedTxtBox.Focus();
        }
    }
}
