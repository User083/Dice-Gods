using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Actor 
{
    public float actorWeight {get; set;}
    public float actorValue { get; set; }
    public string actorName { get; set; }
    public string actorDescription { get; set; }
}
