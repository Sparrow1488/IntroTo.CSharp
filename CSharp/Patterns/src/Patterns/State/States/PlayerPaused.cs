using State.Models;
using State.States.Interfaces;

namespace State.States
{
    public class PlayerPaused : PlayerState
    {
        public PlayerPaused(PlayerViewModel context) : base(context)
        {
        }

        //public override PlayerStateType Type => PlayerStateType.Play;

        public override void Activate()
        {
            Context.Player.Play();
            Context.PlayButton.SetPlayImage();
            Context.PlayerState = new PlayerPlayed(Context);
        }
    }
}
