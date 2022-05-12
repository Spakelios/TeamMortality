using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woah : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            currencyContainer.fertiliser++;
        }
    }
}
