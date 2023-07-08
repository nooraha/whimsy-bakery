using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent touchObject;
    public int itemToCheckId = 0;

    public string objectDescription;

    private void OnMouseDown()
    {
        touchObject.Invoke();
        // play sound
    }

    public void ExamineObject()
    {
        Debug.Log(objectDescription);
    }

    public void KickObject()
    {
        Debug.Log("Kicked object");
    }
}
