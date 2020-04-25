using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Signal contextOn;
    public Signal contextOff;
    public GameObject currentIntObj = null;
    public Transform player;


    void Update()
    {
        if (transform.tag == "Player")
        {

        }
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
