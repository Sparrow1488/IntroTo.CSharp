using System;

namespace Video.Subtitles.Commands
{
    public class PlayerActivate : CommandBase
    {
        public PlayerActivate(Action<object> execute, Func<object, bool> canExecute = null) : base(execute, canExecute)
        {
        }
    }
}
