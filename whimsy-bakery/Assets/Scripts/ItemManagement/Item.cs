using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item 
{
    public string title;
    public string internal_name;
    public int id;
    public string description;
    public Sprite sprite;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    public Item(string title, string internal_name, int id, string description, Dictionary<string, int> stats)
    {
        this.title = title;
        this.internal_name = internal_name;
        this.id = id;
        this.description = description;
        sprite = Resources.Load<Sprite>("Textures/" + internal_name);
        this.stats = stats;
    }

    public override string ToString()
    {
        return "name: " + internal_name + "   id: " + id;
    }

}
