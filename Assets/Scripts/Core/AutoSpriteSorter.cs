using System.Collections.Generic;

using UnityEngine;
public class AutoSpriteSorter : MonoBehaviour
{

    SpriteRenderer tempRend;

    void Awake()
    {

        tempRend = GetComponent<SpriteRenderer>();

    }

    void Update()
    {

        tempRend.sortingOrder = (int)Camera.main.WorldToScreenPoint(this.transform.position).y * -1;

    }
}