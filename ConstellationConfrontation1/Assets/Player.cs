using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var item = other.GetComponent<item>();
        if (item)
        {
            inventory.AddItem(item.Item, 1);
            Destroy(other.gameObject);
        }
    }
    
    private void OnApplicationQuit()
    {
        inventory.container.Clear();
    }
}
