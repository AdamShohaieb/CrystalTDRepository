using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; // A float is a number, even decimals
    public Rigidbody2D rb;

    private Vector2 moveDirection;

    private void Update()
    {
        ProcessInput(); // calls the "ProcessInputs function" every frame
    }

    private void FixedUpdate()
    {
        Move(); // calls the "move function" every frame
    }

    public void ProcessInput() // This is the "ProcessInputs function"
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    private void Move() // This is the "move function"
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed); // this line is irrelevent 
    }
}