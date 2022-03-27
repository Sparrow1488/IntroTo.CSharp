using System;
using System.Collections.Generic;
using System.Threading;
using Command;

internal class Program
{
    private static readonly Sender _sender = new Sender();
    private static List<ICommand> _queue = new List<ICommand>();

    private static void Main()
    {
        var sendMessageCommand = new SendMessageCommand(_sender, "Hello world!", "World");
        _queue.Add(sendMessageCommand);
        ProcessQueue();
        sendMessageCommand.Unexecute();
    }

    private static void ProcessQueue(){
        for (int i = 0; i < _queue.Count; i++)
        {
            var command = _queue[i];
            command.Execute();
            Thread.Sleep(TimeSpan.FromSeconds(2)); // задержка между запросами
        }
    }
}
