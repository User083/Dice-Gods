using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item
{

public string itemID;
public string itemName;
public string itemDesc;
public float itemValue;
public float itemWeight;
public Sprite itemIcon;

public enum ItemTypeSelector
{
    Armour,
    Weapon,
    Accessory
}

public ItemTypeSelector _itemType;

public Item(string itemID, string itemName, string itemDesc, float itemValue, float itemWeight)
{

//initialise variables
this.itemID = itemID;
this.itemName = itemName;
this.itemDesc = itemDesc;
this.itemValue = itemValue;
this.itemWeight = itemWeight;

DetermineType(_itemType);

}

public void DetermineType(ItemTypeSelector _itemType)
{
 
 Debug.Log(_itemType);

}

}
