using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class Buttons : MonoBehaviour
{
   public GameObject level;
   public GameObject ship;
   public GameObject Inventory;
   public GameObject text;
   public GameObject player;
   
   public void OpenLevelselect()
   {
      level.SetActive(true);
      ship.SetActive(false);
      Inventory.SetActive(false);
   }
   public void OpenLevelselect2()
   {
      level.SetActive(true);
      ship.SetActive(false);
      Inventory.SetActive(false);
      text.SetActive(false);
      player.SetActive(false);
   }

   public void closeLevel()
   {
      level.SetActive(false);
      ship.SetActive(true);
      Inventory.SetActive(true);
   }
   
   public void closeLevel2()
   {
      level.SetActive(false);
      ship.SetActive(true);
      Inventory.SetActive(true);
      player.SetActive(true);
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
Time.timeScale = 0f;
   }
   
   public void CLOSEMenuBATTLE()
   {
      Inventory.SetActive(false);
      Time.timeScale = 1f;
   }

   public void Ship()
   {
      SceneManager.LoadScene("UI");
   }

   public void end()
   {
      level.SetActive(false);
      ship.SetActive(false);
      Inventory.SetActive(true);
   }

   public void quit()
   {
      Application.Quit();
      Debug.Log("quit");
   }
}

