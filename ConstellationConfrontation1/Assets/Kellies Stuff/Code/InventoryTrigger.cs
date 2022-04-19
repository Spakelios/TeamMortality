using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTrigger : MonoBehaviour
{
    public GameObject textbox;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            textbox.SetActive(true);
            Debug.Log("enter");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            textbox.SetActive(false);
            Debug.Log("exit");
        }
    }
}
