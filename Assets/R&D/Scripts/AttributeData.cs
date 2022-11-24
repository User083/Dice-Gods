using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeData : MonoBehaviour
{
 public List<Attribute> CoreAttributes = new List<Attribute>();

//  [header("Attributes")]
 Attribute Intelligence = new Attribute(20, 0f, "Intelligence", "", 20);
 Attribute Constitution = new Attribute(20, 0f, "Constitution", "", 20);
 Attribute Wisdom = new Attribute(20, 0f, "Wisdom", "", 20);
 Attribute Dexterity = new Attribute(20, 0f, "Dexterity", "", 20);
 Attribute Strength = new Attribute(20, 0f, "Strength", "", 20);
 Attribute Charisma = new Attribute(20, 0f, "Charisma", "", 20); 
   
  
    
    void Start()
    {
        InitialiseAttributes();
    }

 public void InitialiseAttributes()
 {
    
  CoreAttributes.Add(Intelligence);
  CoreAttributes.Add(Constitution);
  CoreAttributes.Add(Wisdom);
  CoreAttributes.Add(Dexterity);
  CoreAttributes.Add(Strength);
  CoreAttributes.Add(Charisma);
 
 }


}
