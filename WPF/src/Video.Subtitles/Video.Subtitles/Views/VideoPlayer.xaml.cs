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
            Messenger.Default.Send(SubtitlesBlock);
        }
    }
}
