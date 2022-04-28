using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class display : MonoBehaviour
{
    public TextMeshProUGUI coins;
    public TextMeshProUGUI LevelText, ReputationText, money;
    private void Update()
    {
        coins.text = " " + currencyContainer.Money;
        LevelText.text = "Level: " + currencyContainer.Level;
        ReputationText.text = "Reputation: " + currencyContainer.reputation;
        money.text = "Money: " + currencyContainer.Money;

    }

}
