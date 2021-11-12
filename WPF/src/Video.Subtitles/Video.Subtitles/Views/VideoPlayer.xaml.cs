using GalaSoft.MvvmLight.Messaging;
using System.Windows.Controls;

namespace Video.Subtitles.Views
{
    public partial class AdaptiveVideoPlayer : UserControl
    {

        public AdaptiveVideoPlayer()
        {
            InitializeComponent();
            Messenger.Default.Send(Player);
        }

        //private void Player_MediaEnded(object sender, RoutedEventArgs e)
        //{
        //    Player.Position = new TimeSpan(0);
        //    Player.Stop();
        //    MainPlayButton.Visibility = Visibility.Visible;
        //}

    }
}
