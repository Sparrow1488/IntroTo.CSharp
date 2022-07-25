using State.Models;

namespace State.States.Interfaces
{
    public abstract class SubtitlesState
    {
        protected readonly PlayerViewModel Context;

        public SubtitlesState(PlayerViewModel context)
        {
            Context = context;
        }

        public abstract void Activate();
    }
}
