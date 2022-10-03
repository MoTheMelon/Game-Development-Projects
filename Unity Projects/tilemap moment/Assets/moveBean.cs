using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBean : MonoBehaviour
{
   public float speed = 10;
   public float jumpForce = 10;
   bool canJump = false;
   Animator anim;

    void Start(){
        anim = GetComponent<Animator>();
        Debug.Log("start");
    }
    
    void OnCollisionEnter(Collision collision){
        canJump = true;
        Debug.Log("literally is this working");
        if(collision.gameObject.name == "mr jellybean"){
            Debug.Log("the bean has landed.");
        }
        if(collision.gameObject.name == "Tilemap"){
            Debug.Log("tilemap??");
        }
    }
    void OnCollisionExit(Collision collision){
        canJump = false;
        Debug.Log("oncollisionexit?");
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if(Input.GetKey(KeyCode.A)){
            //left
            rb.AddForce(new Vector2(-speed, 0));
        }
        if(Input.GetKey(KeyCode.D)){
            //right
            rb.AddForce(new Vector2(speed, 0));
        }
        if(canJump && Input.GetKey(KeyCode.Space)){
            //jump
            rb.AddForce(new Vector3(0, jumpForce, 0));
            anim.SetBool("isJumping",true);
            Debug.Log("jump!");
        }
        if(Input.GetKey(KeyCode.S)){
            //crouch
            
        }
    }

    
   
}
