using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSlot : MonoBehaviour
{
    public Spell assignedSpell;
    public GameObject mainCharacter;
    public int slotNumber;

    public void AssignSpell(Spell spell)
    {
        assignedSpell = spell;
        gameObject.SetActive(true);
    }
    public void ClearSlot()
    {
        assignedSpell = null;
        gameObject.SetActive(false);
    }
    public void Cast()
    {
        mainCharacter.GetComponent<MainCharacter>().Cast(assignedSpell);

    }
}
