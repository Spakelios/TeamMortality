using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUp : MonoBehaviour {

    private Inventory inventory;
    public Image itemButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            for (int i = 0; i < inventory.items.Length; i++)
            {
                if (inventory.items[i] == 0) { // check whether the slot is EMPTY
                    inventory.items[i] = 1; // makes sure that the slot is now considered FULL
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    InventoryManager.Spawn += 1;
                    Destroy(gameObject);
                    break;
                }
            }
        }
        
    }
}