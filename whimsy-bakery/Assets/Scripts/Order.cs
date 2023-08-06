using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order
{
    public string customerName;
    public int id;
    public Dictionary<int, Item> orderedItems = new Dictionary<int, Item>();

    public Order(string customerName, int id, Dictionary<int, Item> orderedItems)
    {
        this.customerName = customerName;
        this.id = id;
        this.orderedItems = orderedItems;
    }

    public override string ToString()
    {
        return "order / id: " + id +
            " / customer: " + customerName +
            " / contains: " + orderedItems;
    }
}
