using System.Collections.Generic;
[System.Serializable] // This makes the class serializable with Unity's JSON utility
public class GameData
{
    public int level;
    public float health;
    public List<string> inventoryItems = new List<string>();
    // Add other data you need to persist here

    // Constructor
    public GameData()
    {
        // Initialize your data as necessary
        level = 1; // Starting level
        health = 100f; // Starting health
        // inventoryItems is already initialized as an empty list
    }
}
