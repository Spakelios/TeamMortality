using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Health Object", menuName = "Inventory System/Items/health")]
public class HealObject : ItemObject
{
    public int restoreHealthValue;

    public void Awake()
    {
        type = ItemType.Food;
    }
}
