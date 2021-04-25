using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character
{
    public float initialHP;
    public string status;
    public float lowHealthMargin;
    public HealthSystem healthSystem;
    public MagicSystem magicSystem;

    public List<Spell> spells = new List<Spell>();


    public Character(int startHP, int startMP, float healthMarg)
    {
        healthSystem = new HealthSystem(startHP);
        magicSystem = new MagicSystem(startMP);
        spells = new List<Spell>();
        lowHealthMargin = healthMarg;
    }
    public void Cast(Spell spell)
    {
        magicSystem.Cast(spell);
    }
    public void Learn(Spell spell)
    {
        if (spells.Contains(spell))
        {
            return;
        } else
        {
            spells.Add(spell);
        }
        
    }
    public void Heal(int amount)
    {
        healthSystem.Heal(amount);
        HealthCheck();
        
    }
    public void Damage(int amount)
    {
        if (amount > healthSystem.currentHP)
        {
            status = "Dead";
            HealthCheck();
        }
        healthSystem.Damage(amount);
    }
    public string HealthCheck()
    {
        float amountToCheck;
        amountToCheck = healthSystem.maxHP * lowHealthMargin;
        if (healthSystem.currentHP > amountToCheck)
        {
            return "NormalHealth";
        }
        else if (healthSystem.currentHP <= amountToCheck && healthSystem.currentHP > 0)
        {
            return "LowHealth";
        }
        else
        {
            return "Dead";
            
        }
    }
}
   
