using System;

namespace Video.Subtitles.Commands
{
    public class EmptyCommand : CommandBase
    {
        public EmptyCommand(Action<object> execute, Func<object, bool> canExecute = null) : base(execute, canExecute)
        {
        }
    }
}
