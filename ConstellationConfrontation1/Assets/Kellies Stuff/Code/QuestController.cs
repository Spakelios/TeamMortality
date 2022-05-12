using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{

    public GameObject flower, fert;
    void Update()
    {
        if (currencyContainer.flower >= 1)
        {
            flower.SetActive(true);
        }
        else
        {
            flower.SetActive(false);
        }

        if (currencyContainer.fertiliser >= 1)
        {
            fert.SetActive(true);
        }
        else
        {
            fert.SetActive(false);
        }
    }
}
