using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

[Serializable]
public class Item : Actor
{
   
  
    public string itemID { get; set; }
    public string itemName { get; set; }
    public string itemDescription { get; set; }
    public float itemValue { get; set; }
    public float itemWeight { get; set; }
    public Texture2D itemImage { get; set; }
    public List<Property> itemProperties { get; set; }




    //Base methods
    public void updateValue(float adjustedValue)
    {
        itemValue = itemValue + adjustedValue;
    }

    public void updateWeight(float adjustedWeight) 
    {
        itemWeight = itemWeight + adjustedWeight;    
    }

    public void addProperties(Property prop)
    {
        itemProperties.Add(prop);
    }

    public void removeProperties(Property prop) 
    {
        itemProperties.Remove(prop);
    }

    public void destroySelf()
    { 
    Destroy(gameObject);
    }


}
