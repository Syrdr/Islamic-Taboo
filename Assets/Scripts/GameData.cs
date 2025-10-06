using UnityEngine;

public static class GameData
{
    public static int NumberOfPlayers { get; set; } = 6;
    public static int greenScore = 0;
    public static int redScore = 0;
    public static Teams currentTeam = Teams.Green;
    //public static int skips = 3;
    public static bool dataModified = false;
}
public enum Teams
{
    Green,
    Red
}
