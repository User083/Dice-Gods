using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScritableObjects/Character", order = 1)]
[System.Serializable]
public class SO_Character : ScriptableObject
{
    
    
    [Header("Basic Info")]
    
    public string characterName;
    public string characterDescription;
    Health characterHealth = new Health();
    public float characterDefense;
    public float characterStamina;

    public Attribute[] characterAttributes = new Attribute[0];
    public Item[] characterInventory = new Item[0];

}
