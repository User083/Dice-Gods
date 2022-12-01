using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Attribute 
{
    public string attribute;
    public string description;
    public int rank;

    public Attribute(string name, string description, int rank)
    {
        attribute = name;
        this.description = description;
        this.rank = rank;
        
         }

    
}
