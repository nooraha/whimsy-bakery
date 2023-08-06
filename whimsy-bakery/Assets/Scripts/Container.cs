using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Container : MonoBehaviour
{
    public ItemDatabase itemDatabase;
    private protected List<Item> inventory = new List<Item>();
    protected int itemCapacity = 12;

    private void Awake()
    {
        itemDatabase = FindObjectOfType<ItemDatabase>();
    }

    public Item FindItemInDatabase(int itemId)
    {
        return itemDatabase.items.Find(item => item.id == itemId);
    }

    public void AddItemToContainer(int itemId)
    {
        if(CheckTotalItems() < itemCapacity)
        {
            Item itemToAdd = FindItemInDatabase(itemId);
            if (itemToAdd != null)
            {
                inventory.Add(itemToAdd);
                Debug.Log("Added item " + itemToAdd + " to inventory");
            }
            else { Debug.Log("Could not find " + itemId + " in database"); }
        }
        else { Debug.Log(gameObject.name + " inventory full"); }
    }

    public int CheckTotalItems()
    {
        return inventory.Count;
    }

    public void RemoveItemFromInventory(int itemId)
    {
        Item itemToRemove = FindItemInDatabase(itemId);
        if (itemToRemove != null)
        {
            if (CheckAmountOfItem(itemId) > 0)
            {
                inventory.Remove(itemToRemove);
                Debug.Log("Removed item " + itemToRemove + " from inventory");
            }
            else { Debug.Log("Could not find " + itemId + " in inventory"); }

        }
        else { Debug.Log("Could not find " + itemId + " in database"); }

    }

    public int CheckAmountOfItem(int itemId)
    {
        int itemAmount = inventory.Where(item => item.id.Equals(itemId))
            .Select(item => item).Count();

        Debug.Log("Inventory has: " + itemAmount + " occurrences of " + itemId);
        return itemAmount;
    }
}
