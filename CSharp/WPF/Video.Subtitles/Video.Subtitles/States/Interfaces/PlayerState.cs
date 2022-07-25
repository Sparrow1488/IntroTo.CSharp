using Video.Subtitles.ViewModels;

namespace Video.Subtitles.States.Interfaces
{
    public abstract class PlayerState
    {
        protected PlayerViewModel Context { get; set; }

        public PlayerState(PlayerViewModel context)
        {
            Context = context;
        }

        public abstract void Switch();
    }
}
