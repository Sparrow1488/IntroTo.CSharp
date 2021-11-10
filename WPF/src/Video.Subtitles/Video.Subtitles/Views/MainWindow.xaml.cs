using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Video.Subtitles.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MediaPlayer.MaxHeight = SystemParameters.VirtualScreenHeight - 200;
        }
    }
}
