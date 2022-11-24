using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAttribute 
{
 private int baseValue;
 private float baseMultiplier; 

public BaseAttribute(int value, float multiplier)
 {
    this.baseValue = value;
    this.baseMultiplier = multiplier;
 }

 //properties
 
 public int BaseValue
 {
    get {return baseValue;}
 }

  public float BaseMultiplier
 {
    get {return baseMultiplier;}
 }




}
