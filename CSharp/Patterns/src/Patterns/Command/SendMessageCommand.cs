using System;
using Command;

internal class SendMessageCommand : ICommand
{
    public SendMessageCommand(Sender sender, string message, string to) {
        _sender = sender;
        _message = message;
        _to = to;
    }

    private Sender _sender;
    private readonly string _message;
    private readonly string _to;
    private Guid _messageId;

    public void Execute() =>
        _messageId = _sender.SendMessage(_message, _to);

    public void Unexecute() =>
        _sender.DeleteMessage(_messageId);
}