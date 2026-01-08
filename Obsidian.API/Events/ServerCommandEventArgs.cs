using Obsidian.API;
using Obsidian.API.Commands;
using Obsidian.API.Events;

public class ServerCommandEventArgs : BaseMinecraftEventArgs
{
    public Command Command { get; }

    public ServerCommandEventArgs(IServer server, Command command) : base(server)
    {
        this.Command = command;
    }
}
