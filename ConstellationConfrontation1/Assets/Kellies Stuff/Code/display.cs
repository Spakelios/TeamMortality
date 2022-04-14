using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class display : MonoBehaviour
{
    public TextMeshProUGUI coins;
    private void Update()
    {
        coins.text = " " + currencyContainer.Money;
    }

}
