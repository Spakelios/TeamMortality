using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    public GameObject shipBoarding;
    public bool isTouching;

    private void Start()
    {
        shipBoarding.SetActive(false);
        isTouching = false;
    }

    private void FixedUpdate()
    {
        isTouching = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ship")
        {
            shipBoarding.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interact")
        {
            isTouching = true;
        }
    }
}
