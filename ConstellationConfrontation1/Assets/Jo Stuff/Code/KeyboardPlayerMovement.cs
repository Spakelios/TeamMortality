using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    private Vector2 movement;
    public float movementSpeed;
    public bool canMove;

    private void Update()
    {
        if (!canMove)
        {
            return;
        }
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (!canMove)
        {
            return;
        }
        playerRB.MovePosition(playerRB.position + movement * (movementSpeed * Time.fixedDeltaTime));
    }
}
