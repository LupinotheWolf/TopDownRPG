using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainCharacter : Character
{
    public GameObject spellSlot1;
    public GameObject spellSlot2;
    public GameObject spellSlot3;
    public GameObject spellSlot4;
    public GameObject spellSlot5;


    public MainCharacter(int startHP, int startMP, float lowHealthMarg) : base(startHP, startMP, lowHealthMarg)
    {
        healthSystem = new HealthSystem(startHP);
        magicSystem = new MagicSystem(startMP);
        lowHealthMargin = lowHealthMarg;
    }


    public void ActivateSlot(GameObject slot)
    {
        if (slot.GetComponent<SpellSlot>().assignedSpell == null)
        {
            return;
        }
        else
        {
            slot.GetComponent<SpellSlot>().Cast();
        }
    }

}
