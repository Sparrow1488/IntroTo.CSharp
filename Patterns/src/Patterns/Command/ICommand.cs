namespace Command
{
    internal interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}
