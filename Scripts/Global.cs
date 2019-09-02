using Godot;
using System;

public class Global : Node
{
    public bool playingAsHost;
    public Steamworks.CSteamID global_lobbyID;
    public Steamworks.CSteamID player1;
    public Steamworks.CSteamID player2;
}
