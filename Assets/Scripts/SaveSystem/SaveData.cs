using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public static SaveData _current;
    public static SaveData current
    {
        get
        {
            if (_current == null)
            {
                _current = new SaveData();
            }
            return _current;
        }
    }

    public List<Character> customCharacters = new List<Character>();
    public List<Item> customItems = new List<Item>();

    

    public void SaveCustomCharacters(Character character)
    {
        SaveData.current.customCharacters.Add(character);    
       
    }

    public void SaveCustomItems(Item item)
    {
        SaveData.current.customItems.Add(item);

    }

}
