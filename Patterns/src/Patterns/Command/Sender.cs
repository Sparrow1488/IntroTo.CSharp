using System;

internal class Sender
{
    public Guid SendMessage(string message, string to){
        Console.WriteLine($"Send message \"{message}\" TO {to}");
        return Guid.NewGuid();
    }

    public void DeleteMessage(Guid messageId) =>
        Console.WriteLine($"Delete message {messageId}");
}