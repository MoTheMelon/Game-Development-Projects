using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject mrJellybean;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        //pos.y = mrJellybean.transform.position;
        //pos.x = mrJellybean.transform.position;

        //tell camera to move transform
        transform.position = pos;
    }
}
