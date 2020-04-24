using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject currentIntObj = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentIntObj)
        {
            currentIntObj.SendMessage("DoInteraction");
            currentIntObj = null;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("intObject"))
        {
            currentIntObj = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("intObject"))
        {
            if (other.gameObject == currentIntObj)
            {
                currentIntObj = null;
            }
        }
    }
}
