using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
 private VisualElement root;
 private GameMaster GM;
 private Button buttonRoll;
 private FloatField damageResult;
 private TextField successResult;
 private IntegerField gameTurn;
 private TextField initiatorName;
 private FloatField initiatorHealth;
 private FloatField initiatorBaseDamage;
 private FloatField initiatorBaseDefence;

 private TextField targetName;
 private FloatField targetHealth;
 private FloatField targetBaseDamage;
 private FloatField targetBaseDefence;
 private TextField attackerStatus;
 
   private void Start() {
GM = GetComponent<GameMaster>();
   InitChars();
   

   }
  void OnEnable()
   {
    //UI Init   
   root = GetComponent<UIDocument>().rootVisualElement;
  
   initiatorName = root.Q<TextField>("InitiatorName");
   
   initiatorHealth = root.Q<FloatField>("InitiatorHealth");
   initiatorBaseDamage = root.Q<FloatField>("InitiatorBaseDamage");
   initiatorBaseDefence = root.Q<FloatField>("InitiatorBaseDefence");
   targetName = root.Q<TextField>("TargetName");
   attackerStatus = root.Q<TextField>("AttackerStatus");
    targetHealth = root.Q<FloatField>("TargetHealth");
    targetBaseDamage = root.Q<FloatField>("TargetBaseDamage");
   targetBaseDefence = root.Q<FloatField>("TargetBaseDefence");
    gameTurn = root.Q<IntegerField>("GameTurn");
      buttonRoll = root.Q<Button>("ButtonRoll");
    damageResult = root.Q<FloatField>("DamageResult");
   successResult = root.Q<TextField>("SuccessResult");  
      // Roll the dice for attack
    
 buttonRoll.clicked += () => 
    {
      
       GM.UpdateTurn();
       gameTurn.value = GM.gameTurn; 
       attackerStatus.value = GM.currentAttacker.characterName;
      float result = GM.RollDice(GM.currentAttacker.characterSuccessChance,GM.currentAttacker.characterBaseDamage,GM.currentDefender.characterBaseDefence);
    if(result > 0)
    {
      successResult.value= "Succeeded";
    }
    else
    {
      successResult.value = "Failed";
    }

      damageResult.value = result;

      GM.CalcHealth(result);
      
      targetHealth.value = GM.TargetCharacter.characterCurrentHealth;
      initiatorHealth.value = GM.InitiatorCharacter.characterCurrentHealth;

    }; 

   }
   
   void InitChars()
   {
     initiatorName.value = GM.InitiatorCharacter.characterName;
     initiatorHealth.value = GM.InitiatorCharacter.characterMaxHealth;
     initiatorBaseDamage.value = GM.InitiatorCharacter.characterBaseDamage;
     initiatorBaseDefence.value = GM.InitiatorCharacter.characterBaseDefence;
     targetName.value = GM.TargetCharacter.characterName;
     targetHealth.value = GM.TargetCharacter.characterMaxHealth;
     targetBaseDamage.value = GM.TargetCharacter.characterBaseDamage;
     targetBaseDefence.value = GM.TargetCharacter.characterBaseDefence;
     attackerStatus.value = GM.currentAttacker.characterName;
   }
 

 
   





};
