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
    
    void OnCollisionEnter2D(Collision2D collision){
        canJump = true;
                anim.SetBool("isJumping",false);
        if(collision.gameObject.name == "mr jellybean"){
            Debug.Log("the bean has landed.");
        }
        if(collision.gameObject.name == "Tilemap"){
            Debug.Log("tilemap??");
        }
    }
    void OnCollisionExit2D(Collision2D collision){
        canJump = false;
        Debug.Log("oncollisionexit?");
    }

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Debug.Log(canJump);
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
