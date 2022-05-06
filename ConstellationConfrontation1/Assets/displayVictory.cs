using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class displayVictory : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    void Update()
    {
        levelText.text = "Level: " + currencyContainer.Level;
    }
}
