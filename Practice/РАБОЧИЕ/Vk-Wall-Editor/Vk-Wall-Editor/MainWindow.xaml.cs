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
using xNet;

namespace Vk_Wall_Editor
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
        private string accessToken = "3f13f12c7f9fc5f8d663dc5b05bb0b6e8aaef9435ea4dfd6e3208becbf98d812af219c315335f66b9720a";

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            VkApi api = new VkApi(accessToken);
            var usersID = api.GetOnline();
            string all = "";
            foreach (var id in usersID)
            {
                all += id + "\n";
            }
            MessageBox.Show(all);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            VkApi api = new VkApi(accessToken);
            var friend = api.GetFriends();
            MessageBox.Show(friend);
        }

        //access_token=3f13f12c7f9fc5f8d663dc5b05bb0b6e8aaef9435ea4dfd6e3208becbf98d812af219c315335f66b9720a
        //expires_in=86400
        //user_id=327069579
    }
}
