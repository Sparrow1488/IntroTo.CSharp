using System.Windows;

namespace Video.Subtitles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MediaPlayer.MaxHeight = SystemParameters.VirtualScreenHeight - 200;
        }
    }
}
