using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "BATTLES", menuName = "Characters/Player")]
public class STATS : ScriptableObject
{
    public string Name;
    public string level;
    public static int attack;
    public static int defense;
    public int hp;
    public int maxHp;
    public int damage;
    
    public Sprite playerImage;
    public  Sprite enemyImage;


    public bool TakeDamage(int dmg)
    {
        hp -= dmg;  // if damage is taken remove from hp

        if (hp <= 0)
            return true;
        else
            return false;
    }
    
    public void Heal(int amount) 
    {
        hp += amount; // increase health 
        if (hp > maxHp) 
            hp = maxHp;
    }
    
}
