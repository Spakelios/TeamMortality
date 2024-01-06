using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whhh : MonoBehaviour
{
    public GameObject battle;
    public GameObject iceman;

    public void Update()
    {
        if (battle.activeInHierarchy)
        { 
            Destroy(iceman);
        }
    }
}
