using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // the speed the characters moves at and it can be changed within the hiearchy
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    
    // Update is called once per frame
    void Update()
    {
       // telling the game what direction the player should be walking towards
        movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
