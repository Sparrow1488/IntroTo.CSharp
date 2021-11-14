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
            Context.PlayerState = new PlayerPaused(Context);
        }
    }
}
