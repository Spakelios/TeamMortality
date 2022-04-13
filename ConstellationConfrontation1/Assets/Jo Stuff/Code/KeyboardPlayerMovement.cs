using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    private Vector2 movement;
    public float movementSpeed;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + movement * (movementSpeed * Time.fixedDeltaTime));
    }
}
