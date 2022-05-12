using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crazy : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            currencyContainer.fertiliser = 0;
        }
    }
}
