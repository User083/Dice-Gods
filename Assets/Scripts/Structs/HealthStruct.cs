using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct HealthStruct
{
    public float maxHealth;
    public float currentHealth;

    public HealthStruct(float maxHealth, float currentHealth)
    {
        this.maxHealth = maxHealth;
        this.currentHealth = currentHealth;
    }

}
