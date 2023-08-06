using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public int itemRequiredId = 0;
    public int harvestableId = 0;
    public string examineDescription;
    public int objectItemId = 0;

    private PlayerInventory inventory;
    public UnityEvent interactionEvent;


    private void Awake()
    {
        inventory = FindObjectOfType<PlayerInventory>();
    }

    private void OnMouseDown()
    {
        if(itemRequiredId == 0 || inventory.CheckAmountOfItem(itemRequiredId) > 0)
        {
            interactionEvent.Invoke();
        }
        else { Debug.Log("Required item " + itemRequiredId + " not found in inventory"); }
        // play sound
    }

    public void ExamineObject()
    {
        Debug.Log(examineDescription);
    }

    public void KickObject()
    {
        Debug.Log("Kicked " + gameObject.name);
    }

    public void HarvestFromObject()
    {
        Debug.Log("Harvested from " + gameObject.name);
        inventory.AddItemToContainer(harvestableId);
    }

    public void PickUpObject()
    {
        Debug.Log("Picked up " + gameObject);
        inventory.AddItemToContainer(objectItemId);
        Destroy(gameObject);
    }
}
