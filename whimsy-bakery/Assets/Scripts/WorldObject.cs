using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldObject : MonoBehaviour
{
    public string title;
    public string internalName;
    public int id;
    public Sprite sprite;
    public Dictionary<string, int> stats = new Dictionary<string, int>();
    public string examineDescription;

    /* public WorldObject(string title, string internalName, int id,
        Dictionary<string, int> stats)
    {
        this.title = title;
        this.id = id;
        this.internalName = internalName;
        sprite = Resources.Load<Sprite>("Textures/ObjectSprites" + internalName);
        this.stats = stats;
    } */

    public override string ToString()
    {
        return "object / name: " + internalName + " / id: " + id;
    }
}
