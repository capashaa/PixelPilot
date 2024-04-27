﻿using PixelPilot.PixelGameClient.Messages.Received;

namespace PixelPilot.PixelGameClient.Messages.Constants;

public enum WorldMessageType : int
{
    PlayerInit,
    UpdateRights,
    WorldMetadata,
    WorldCleared,
    WorldReloaded,
    WorldBlockPlaced,
    ChatMessage,
    SystemMessage,
    PlayerJoined,
    PlayerLeft,
    PlayerMoved,
    PlayerFace,
    PlayerGodMode,
    PlayerModMode,
    PlayerCheckpoint,
    PlayerRespawn,
    PlayerReset,
    PlayerCrown,
    PlayerKeyPressed,
    PlayerCounters,
    PlayerWin,
    PlayerLocalSwitchChanged,
    PlayerLocalSwitchReset,
    GlobalSwitchChanged,
    GlobalSwitchReset,
}

static class WorldMessageTypeExtensions
{
    public static Type? AsPacketType(this WorldMessageType type)
    {
        return type switch
        {
            WorldMessageType.PlayerInit => typeof(InitPacket),
            WorldMessageType.PlayerJoined => typeof(PlayerJoinPacket),
            WorldMessageType.PlayerLeft => typeof(PlayerLeavePacket),
            WorldMessageType.ChatMessage => typeof(PlayerChatPacket),
            WorldMessageType.PlayerMoved => typeof(PlayerMovePacket),
            WorldMessageType.PlayerGodMode => typeof(PlayerGodmodePacket),
            WorldMessageType.PlayerModMode => typeof(PlayerModMode),
            WorldMessageType.PlayerFace => typeof(PlayerFacePacket),
            WorldMessageType.PlayerCounters => typeof(PlayerStatsChangePacket),
            WorldMessageType.PlayerRespawn => typeof(PlayerRespawnPacket),
            WorldMessageType.WorldBlockPlaced => typeof(WorldBlockPlacedPacket),
            WorldMessageType.PlayerCrown => typeof(PlayerCrownPacket),
            WorldMessageType.PlayerReset => typeof(PlayerResetPacket),
            WorldMessageType.PlayerCheckpoint => typeof(PlayerCheckpointPacket),
            WorldMessageType.PlayerKeyPressed => typeof(PlayerKeyPressedPacket),
            WorldMessageType.PlayerLocalSwitchChanged => typeof(LocalSwitchChangedPacket),
            WorldMessageType.GlobalSwitchChanged => typeof(GlobalSwitchChangedPacket),
            WorldMessageType.WorldReloaded => typeof(WorldReloadedPacket),
            WorldMessageType.WorldCleared => typeof(WorldClearedPacket),
            _ => null
        };
    }
}