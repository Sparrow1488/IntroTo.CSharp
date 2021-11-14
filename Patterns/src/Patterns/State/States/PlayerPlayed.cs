using State.Models;
using State.States.Interfaces;
using System;

namespace State.States
{
    public class PlayerPlayed : PlayerState
    {
        public PlayerPlayed(PlayerViewModel context) : base(context)
        {
        }

        //public override PlayerStateType Type => throw new NotImplementedException();

        public override void Activate()
        {
            Context.Player.Pause();
            Context.PlayButton.SetPauseImage();
            Context.PlayerState = new PlayerPaused(Context);
        }
    }
}
