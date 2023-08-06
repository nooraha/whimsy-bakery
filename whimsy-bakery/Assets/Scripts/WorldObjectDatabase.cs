using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObjectDatabase : MonoBehaviour
{
    public List<WorldObject> worldObjects = new List<WorldObject>();

    /* void BuildDatabase()
    {
        worldObjects = new List<WorldObject>()
        {
            new WorldObject("Chest", "chest", 3,
            new Dictionary<string, int>
            {
                { "Durability", 5 }
            })
        };
    }

    private void Awake()
    {
        BuildDatabase();
    } */
}
