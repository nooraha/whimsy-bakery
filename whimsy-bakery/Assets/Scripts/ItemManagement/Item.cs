using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public string title;
    public string internalName;
    public int id;
    public string description;
    public Sprite sprite;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(string title, string internalName, int id, string description,
        Dictionary<string, int> stats)
    {
        this.title = title;
        this.internalName = internalName;
        this.id = id;
        this.description = description;
        sprite = Resources.Load<Sprite>("Textures/ItemSprites" + internalName);
        this.stats = stats;
    }

    public override string ToString()
    {
        return "item / name: " + internalName + " / id: " + id;
    }

}
