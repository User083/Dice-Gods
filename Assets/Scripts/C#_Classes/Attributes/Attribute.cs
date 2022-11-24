using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute : BaseAttribute
{
 private string attName;
 private string attDescription;
 private int finalValue;
 private int maxRank;
 private List<Modifier> rawModifiers; 
 private List<Modifier> finalModifiers;

//constructor
public Attribute(int baseValue, float baseMultiplier, string name, string description, int maxRank): base(baseValue, baseMultiplier)
{
   this.attName = name;
   this.attDescription = description;
   this.maxRank = maxRank;
   this.rawModifiers = new List<Modifier>();
   this.finalModifiers = new List<Modifier>();
   this.finalValue = baseValue;
}


// populate modifier lists
public void PopulateModList(Modifier mod)
{
    if(mod.isRaw)
    {
      rawModifiers.Add(mod);  
    }
    else
    {
        finalModifiers.Add(mod);
    }
}

//remove mods from lists
public void RemoveRawModifier(Modifier mod)
{
    rawModifiers.Remove(mod);
}

public void RemoveFinalModifier(Modifier mod)
{
    finalModifiers.Remove(mod);
}

//calculating the modifiers to be applied to the raw attribute
public int CalculateTotalValue()
{
    finalValue = BaseValue;

    int rawModifierValue = 0;
    float rawModifierMultiplier = 0f;

    if(rawModifiers.Count != 0)
    {
       foreach(Modifier mod in rawModifiers) 
       {
        rawModifierValue += mod.BaseValue;
        rawModifierMultiplier += mod.BaseMultiplier;
       }

       finalValue += rawModifierValue;
       finalValue *= (1 + (int)rawModifierMultiplier);

    }

    int finalModifierValue = 0;
    float finalModifierMultiplier = 0f;

    if(finalModifiers.Count != 0)
    {
       foreach(Modifier mod in finalModifiers) 
       {
        finalModifierValue += mod.BaseValue;
        finalModifierMultiplier += mod.BaseMultiplier;
       }

       finalValue += finalModifierValue;
       finalValue *= (1 + (int)finalModifierMultiplier);  
    }
    return finalValue;
}

public int FinalValue
{
    get {return CalculateTotalValue();}
}

}
