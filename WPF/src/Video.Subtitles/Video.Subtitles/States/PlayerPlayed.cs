using System;
using System.Windows;
using Video.Subtitles.States.Interfaces;
using Video.Subtitles.ViewModels;

namespace Video.Subtitles.States
{
    public class PlayerPlayed : PlayerState
    {
        public PlayerPlayed(PlayerViewModel context) : base(context) { }

        public override void Switch()
        {
            Context.PlayerItem.Play();
            Context.SubtitlesService.Start();
            Context.PlayerItem.MediaEnded += Player_MediaEnded;
            Context.PlayerState = new PlayerPaused(Context);
        }
        private void Player_MediaEnded(object sender, RoutedEventArgs e)
        {
            Context.PlayerItem.Position = new TimeSpan();
            Context.PlayerItem.Play();
        }
    }
}
