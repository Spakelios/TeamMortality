using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butts : MonoBehaviour
{
    public GameObject level, ship, Inventory, player;
    public void closeLevel2()
    {
        level.SetActive(false);
        ship.SetActive(true);
        player.SetActive(true);
    }
}
