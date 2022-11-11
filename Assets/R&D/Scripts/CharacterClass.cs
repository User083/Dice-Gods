using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterClass : MonoBehaviour
{
   public string characterName;
   public float characterMaxHealth;
   public float characterCurrentHealth;
   public float characterBaseDamage;
   public float characterBaseDefence;
   public float characterSuccessChance;
   public bool isTheInitiator = false;
   public bool isTheAttacker = false;
   public bool isDead = false;

   public void InitialiseCharacter(string name, float maxHealth, float baseDamage, float baseDefence, float successChance)
   {
        characterName = name;
        characterMaxHealth = maxHealth;
        characterBaseDamage = baseDamage;
        characterBaseDefence = baseDefence;
        characterCurrentHealth = characterMaxHealth;
        characterSuccessChance = successChance;
      
   }
   
   public void TakeDamage(float damage)
   {
        if(!isDead){
          characterCurrentHealth = characterCurrentHealth - damage;  
        }
        
   }

   void CheckIsDead()
   {
    if(characterCurrentHealth == 0)
    {
        isDead = true;
    }
    else
    {
        isDead = false;
    }
   }

   
}
