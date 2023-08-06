using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayerInventory : Container
{
    private void Start()
    {
        itemCapacity = 20;
        AddItemToContainer(3);
        AddItemToContainer(3);
        AddItemToContainer(4);
    }

}
