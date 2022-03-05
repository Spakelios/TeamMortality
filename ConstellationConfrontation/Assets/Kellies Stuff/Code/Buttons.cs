using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
   public GameObject level;
   public GameObject ship;
   
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
}
