using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public Lupino lupino;
    public GameObject spellSlot1;

    public delegate void Damage(int amount);
    public event Damage OnDamage;
    public delegate void Heal(int amount);
    public event Heal OnHeal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Spell1"))
        {
            spellSlot1.GetComponent<SpellSlot>().Cast();
        }


        //HEAL DEBUG, MAKE SURE TO REMOVE
        if (Input.GetButtonDown("Heal"))
        {
            if (OnHeal != null)
            {
                OnHeal.Invoke(5);
            }
        }
        if (Input.GetButtonDown("Damage"))
        {
            if (OnDamage != null)
            {
                OnDamage.Invoke(5);
            }
        }
    }
}
