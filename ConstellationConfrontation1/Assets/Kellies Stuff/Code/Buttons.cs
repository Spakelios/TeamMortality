using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
   public GameObject level;
   public GameObject ship;
   public GameObject Inventory;
   
   public void OpenLevelselect()
   {
      level.SetActive(true);
      ship.SetActive(false);
   }

   public void closeLevel()
   {
      level.SetActive(false);
      ship.SetActive(true);
   }
   
   public void Menu()
   {
      level.SetActive(false);
      ship.SetActive(false);
      Inventory.SetActive(true);
   }
   
   public void CloseMenu()
   {
      level.SetActive(false);
      ship.SetActive(true);
      Inventory.SetActive(false);
   }
}
