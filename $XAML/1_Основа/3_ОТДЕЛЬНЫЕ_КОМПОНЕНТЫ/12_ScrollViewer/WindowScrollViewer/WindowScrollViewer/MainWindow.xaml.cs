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

namespace WindowScrollViewer
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Наверное стоит упомянуть тут более частую задачу - 
            //прокрутить до нужного элемента, чтобы человек не искал 
            //его вручную. Нужно вызвать BringIntoView() на элементе, 
            //к которому необходимо прокрутить.
            bringElem.BringIntoView();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
