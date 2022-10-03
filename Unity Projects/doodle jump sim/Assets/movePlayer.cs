using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if(Input.GetKey(KeyCode.LeftArrow)){
            rb.AddForce(new Vector2(-speed, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            rb.AddForce(new Vector2(speed, 0));
        }
    }
}
