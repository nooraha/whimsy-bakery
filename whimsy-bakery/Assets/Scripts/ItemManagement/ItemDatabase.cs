using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{

    public List<Item> items = new List<Item>();

    void BuildDatabase()
    {
        items = new List<Item>()
        {
            new Item("Rotten apple", "rotten_apple", 3,
            "An apple that contains a rotten soul",
            new Dictionary<string, int>
            {
                {"Saturation", 5 },
                {"Sweetness", 3 },
                {"Rarity", 1 }
            }),
            new Item("Eyeball cupcake", "eyeball_cupcake", 4,
            "A chocolate cupcake with pink frosting, topped with an eyeball",
            new Dictionary<string, int>
            {
                {"Saturation", 8 },
                {"Sweetness", 9 },
                {"Rarity", 3 }
            }),
            new Item("Whisk", "whisk", 5,
            "Used for whisking",
            new Dictionary<string, int>
            {
                {"Speed", 8 },
                {"Durability", 64 }
            })
        };
    }

    private void Awake()
    {
        BuildDatabase();
    }
}
