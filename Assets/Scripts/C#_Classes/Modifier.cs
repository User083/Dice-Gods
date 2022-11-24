using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifier : BaseAttribute
{
  public bool isRaw;
  private float duration;
  private string modName;
  private string modDescription;
  

  //still need to sort out how types will work, but potentially an enum for now
  public enum modType{};


public Modifier(int baseValue, float baseMultiplier, string name, string description) : base(baseValue, baseMultiplier)
{
  this.duration = 0f;
  this.modName = name;
  this.modDescription = description;
  

}
  
  //get/set timer duration variable
  public float Duration
  {
    get { return duration;}
    set { duration = value;}
  }


  //timer function for timed duration modifiers -- i.e. modifiers that last for x amount of time
  public IEnumerator Timer(float timeRemaining)
  {
    duration = timeRemaining;
    while(duration > 0)
    {
        yield return new WaitForSeconds(1.0f);
        duration--;
    }
  }



  
}
