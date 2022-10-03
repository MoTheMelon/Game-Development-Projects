using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onGround : MonoBehaviour
{
       Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
     void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("hahahaha found it");
        if(collision.relativeVelocity.y <= 0f){
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

        if(rb != null)
        {
           anim.SetBool("isJumping",false);
        }
        }
    }
}
