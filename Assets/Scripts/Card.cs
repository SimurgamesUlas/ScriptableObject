using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "New Card", fileName = "Card")] 
public class Card : ScriptableObject
{
    public new string name;
    public string description;
    
    public Sprite artwork;
    
    public int mana;
    public int attack;

    public int health;
}
