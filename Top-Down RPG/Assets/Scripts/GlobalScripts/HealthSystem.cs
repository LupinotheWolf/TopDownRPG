using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
    public int currentHP;
    public int maxHP;

    public HealthSystem(int maxhp)
    {
        maxHP = maxhp;
        currentHP = maxHP;
    }

    public float GetHealthPercent()
    {
        return currentHP / maxHP;
    }
    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
    }
    public void Damage(int amount)
    {
        currentHP -= amount;
        if (currentHP <0)
        {
            currentHP = 0;
        }
    }
}
