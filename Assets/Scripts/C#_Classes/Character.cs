using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character : Actor
{
    public HealthStruct Health;
    

    public Character(string name, string description, float weight, float value, float maxHealth)
    {
        actorName= name;
        actorDescription= description;
        actorWeight= weight;
        actorValue= value;
        Health = new HealthStruct(maxHealth, maxHealth);
    }
}
