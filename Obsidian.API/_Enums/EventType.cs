namespace Obsidian.API;

public enum EventType
{
    PacketReceived,
    QueuePacket,
    PlayerJoin,
    PlayerLeave,
    PlayerTeleported,
    PermissionGranted,
    PermissionRevoked,
    ContainerClick,
    BlockBreak,
    IncomingChatMessage,
    ServerStatusRequest,
    ServerCommand,
    EntityInteract,
    PlayerAttackEntity,
    PlayerInteract,
    ContainerClosed,
    Custom
}
