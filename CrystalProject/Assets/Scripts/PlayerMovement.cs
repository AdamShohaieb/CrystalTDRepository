using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // "FixedUpdate" and "Update" are basically the same 

    // A float is any number  
    // A int is only whole numbers 
    // A string is like text and stuff

    public float moveSpeed; 
    public Rigidbody2D rb;

    private Vector2 moveDirection;

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed); 
    }
}

// iejwjijeijwijeij debussy is the best