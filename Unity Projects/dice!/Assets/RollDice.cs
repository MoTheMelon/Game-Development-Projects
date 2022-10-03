using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDice : MonoBehaviour
{
    public Rigidbody rb;
    public float forceY = 300;
    public float forceX = 300;
    public float rotation = 600;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            // shoots dice into air x, y, z
            rb.AddForce(new Vector3(Random.Range(-forceX,forceX), forceY, 0));
            rb.AddTorque(new Vector3(Random.Range(0, rotation), Random.Range(0, rotation), Random.Range(0, rotation)));
        }
    }
}
