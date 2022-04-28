using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Variables/Integer Variable")]
public class currencyContainer : ScriptableObject
{
    public static int Money = 0;
    public static int Level = 20;
    public static int reputation = 50;
}