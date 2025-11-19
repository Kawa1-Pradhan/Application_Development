using System;

public class Player
{
    // Instance fields
    public string playerName;
    public int level;
    public int health;

    // Default constructor
    public Player()
    {
        Console.WriteLine("Default constructer called");
    }

    // Parameterized constructor
    public Player(string name, int lvl, int hp)
    {
        playerName = name;
        level = lvl;
        health = hp;
    }
}