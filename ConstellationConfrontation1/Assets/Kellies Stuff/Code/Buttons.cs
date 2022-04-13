using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
   public GameObject level;
   public GameObject ship;
   public GameObject Inventory;
   public GameObject shipDecision;
   
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
   
   public void OPEnMenuBATTLE()
   {
Inventory.SetActive(true);
   }
   
   public void CLOSEMenuBATTLE()
   {
      Inventory.SetActive(false);
   }

   public void BoardShip()
   {
      SceneManager.LoadScene("UI");
      Time.timeScale = 1f;
   }

   public void GetOffShip()
   {
      Time.timeScale = 1f;
      shipDecision.SetActive(false);
   }
}

