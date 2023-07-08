using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Inventory : MonoBehaviour
{
    public ItemDatabase itemDatabase;

    List<Item> player_items = new List<Item>();

    public Item FindItemInDatabaseFromId(int item_id)
    {
        return itemDatabase.items.First(item => item.id == item_id);
    }

    public void AddItemToInventory(int item_id)
    {
        Item item_to_add = FindItemInDatabaseFromId(item_id);
        if(item_to_add != null)
        {
            player_items.Add(item_to_add);
            Debug.Log("Added item " + item_to_add + " to inventory");
        }
        else
        {
            Debug.Log("Could not find " + item_id + " in database");
        }
    }

    public void RemoveItemFromInventory(int item_id)
    {
        Item item_to_remove = FindItemInDatabaseFromId(item_id);
        if(item_to_remove != null)
        {
            if(CheckAmountOfItem(item_id) > 0)
            {
                player_items.Remove(item_to_remove);
                Debug.Log("Removed item " + item_to_remove + " from inventory");
            }
            else
            {
                Debug.Log("Could not find " + item_id + " in inventory");
            }

        }
        else
        {
            Debug.Log("Could not find " + item_id + " in database");
        }

    }

    public int CheckAmountOfItem(int item_id)
    {
        int item_amount = player_items.Where(item => item.id.Equals(item_id))
            .Select(item => item).Count();

        Debug.Log("Inventory has: " + item_amount + " occurrences of " + item_id);
        return item_amount;
    }

    private void Start()
    {
        AddItemToInventory(3);
        AddItemToInventory(4);
        AddItemToInventory(5);
    }
}
