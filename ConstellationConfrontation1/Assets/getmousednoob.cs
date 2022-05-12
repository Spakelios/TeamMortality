using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getmousednoob : MonoBehaviour
{
    public AudioSource boop;
    public void OnMouseOver()
    {
        boop.Play();
    }
    
}
