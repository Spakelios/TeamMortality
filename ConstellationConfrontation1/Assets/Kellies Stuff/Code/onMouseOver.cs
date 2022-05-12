using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onMouseOver : MonoBehaviour
{
    public Button Button;
    public AudioSource boop;
    public void OnMouseOver()
    {
        Button.interactable = true;
        boop.Play();
    }
    
    public void OnMouseExit()
    {
        Button.interactable = false;
    }
}
