using System;
using System.Windows;
using System.Windows.Controls;

namespace Video.Subtitles.Views
{
    public partial class VideoPlayer : UserControl
    {

        public VideoPlayer()
        {
            InitializeComponent();
            Player.MediaEnded += Player_MediaEnded;
        }

        private void Player_MediaEnded(object sender, RoutedEventArgs e)
        {
            Player.Position = new TimeSpan(0);
            Player.Stop();
            MainPlayButton.Visibility = Visibility.Visible;
        }

    }
}
