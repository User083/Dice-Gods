using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharClassTest : MonoBehaviour
{
   
   //[Header("Basic Info")]
   public string charName {get; set;}
   public string charDesc {get; set;}

   //[Header("Attributes")]
   public List<Attribute> CharacterAttributes;

  // [Header("Stats")]
   public float baseDamage {get; set;}
   public float baseWeaponDamage {get; set;}
   public float baseDefense {get; set;} 
   
   //[Header("Health")]
   public float maxHealth {get; set;}
   public float currentHealth {get; set;}

    public GameObject Database;

    
    
void Start()
{
    InitialiseCharacter();
    
}

public void InitialiseCharacter()
{
    currentHealth = maxHealth;

}

}
