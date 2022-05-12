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

    private void Start()
    {
        canMove = true;
        Time.timeScale = 1f;
    }

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

        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Animator>().Play("player");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animator>().Play("player4");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Animator>().Play("player3");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Animator>().Play("player2");        
        }
        else
        {
            GetComponent<Animator>().StopPlayback();
        }
        
    }
}

