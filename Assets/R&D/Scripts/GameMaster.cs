using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{

   public int gameTurn = 1;
   public CharacterClass InitiatorCharacter;
   public CharacterClass TargetCharacter;
   public GameObject CharacterDatabase;
   public CharacterClass currentAttacker;
   public CharacterClass currentDefender;
  

  
   
   
   void Start()
   {
    CharacterDatabase = GameObject.Find("CharacterDatabase");
    InitiatorCharacter = CharacterDatabase.GetComponent<Sourn>();
    TargetCharacter = CharacterDatabase.GetComponent<Aedh>();
    InitiatorCharacter.isTheAttacker = true;

   }
   

   
    //calculate success or failure of action, then calculates final damage
    public float RollDice(float successChance, float baseDamage, float baseDefense){

         float randomChance = Random.Range(0,100);

        if(successChance >= randomChance)
        {
            return baseDamage - baseDefense;
        }
        else
        {
            return 0f;
        }
   
    }

    //Updates health after an attack
       public void CalcHealth(float totalDamage){
        currentAttacker.characterCurrentHealth = currentAttacker.characterCurrentHealth - totalDamage;
        

    }


//Update the battle turn
public void UpdateTurn()
{
    gameTurn = gameTurn + 1;
    if(InitiatorCharacter.isTheAttacker)
  {
    
    currentAttacker = InitiatorCharacter;
    currentDefender = TargetCharacter;
    InitiatorCharacter.isTheAttacker = false;
    TargetCharacter.isTheAttacker = true;
  }
  else if (TargetCharacter.isTheAttacker)
  {
 currentAttacker = TargetCharacter;
 currentDefender= InitiatorCharacter;
    InitiatorCharacter.isTheAttacker = true;
 TargetCharacter.isTheAttacker = false;
  }
}



   
}
