using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform targetToFollow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -.5f, 2.3f),
        Mathf.Clamp(targetToFollow.position.y, -3f, -.4f), (transform.position.z));
        // transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }
}
