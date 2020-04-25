using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public Signal contextOn;
    public Signal contextOff;
    public void DoInteraction()

    {
        gameObject.SetActive(false);
        contextOff.Raise();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        contextOn.Raise();
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        contextOff.Raise();
    }
}
