using State.Models;

namespace State.States.Interfaces
{
    public abstract class PlayerState
    {
        protected readonly PlayerViewModel Context;

        public PlayerState(PlayerViewModel context)
        {
            Context = context;
        }

        public abstract void Activate();
    }
}
