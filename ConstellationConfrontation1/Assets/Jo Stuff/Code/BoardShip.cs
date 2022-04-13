using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardShip : MonoBehaviour
{
    public GameObject shipBoarding;
    public bool isTouching;

    private void Start()
    {
        shipBoarding.SetActive(false);
        isTouching = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ship")
        {
            isTouching = true;
            shipBoarding.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
