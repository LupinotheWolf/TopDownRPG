using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSystem
{
    public int maxMP;
    public int currentMP;
    public int maxSlots;

    public MagicSystem(int maxmp)
    {
        maxMP = maxmp;
        currentMP = maxMP;
        if (maxMP > 0 && maxMP <= 20)
        {
            maxSlots = 1;
        }
        else if (maxMP > 20 && maxMP <= 40)
        {
            maxSlots = 2;
        }
        else if (maxMP > 40 && maxMP <= 60)
        {
            maxSlots = 3;
        }
        else if (maxMP > 60 && maxMP <= 80)
        {
            maxSlots = 4;
        }
        else if (maxMP > 80 && maxMP <= 100)
        {
            maxSlots = 5;
        }
    }

    public float GetMagicPercent()
    {
        return currentMP / maxMP;
    }
    public void SetMaxSlots()
    {
        if (maxMP > 0 && maxMP <= 20)
        {
            maxSlots = 1;
        }
        else if (maxMP > 20 && maxMP <= 40)
        {
            maxSlots = 2;
        }
        else if (maxMP > 40 && maxMP <= 60)
        {
            maxSlots = 3;
        }
        else if (maxMP > 60 && maxMP <= 80)
        {
            maxSlots = 4;
        }
        else if (maxMP > 80 && maxMP <= 100)
        {
            maxSlots = 5;
        }
    }
    public void Cast(Spell spell)
    {
        if (currentMP < spell.requiredMP)
        {
            //Cannot Cast Spell
            Debug.Log("Cannot cast spell " + spell.name + ". Not enough MP");
        }
        else
        {
            currentMP -= spell.requiredMP;
            Debug.Log("Casted the spell " + spell.name + " Successfully!!!");
        }
    }
}
