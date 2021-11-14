using Video.Subtitles.States.Interfaces;
using Video.Subtitles.ViewModels;

namespace Video.Subtitles.States
{
    class PlayerPaused : PlayerState
    {
        public PlayerPaused(PlayerViewModel context) : base(context) { }

        public override void Switch()
        {
            Context.PlayerItem.Pause();
            Context.PlayerState = new PlayerPlayed(Context);
        }
    }
}
