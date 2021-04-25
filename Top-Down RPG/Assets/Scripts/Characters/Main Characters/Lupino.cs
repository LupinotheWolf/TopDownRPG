using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lupino : MonoBehaviour
{
    public GameObject spellSlot1;
    public Actions actions;

    //instance of lupino class for game
    public MainCharacter lupino = new MainCharacter(30, 10, 0.2f);


    public delegate void UpdateHealth();
    public event UpdateHealth OnHealthUpdate;
    public delegate void Death();
    public event Death OnDeath;

    void Start()
    {
        Spell fire = new Spell(1, "Fire", 10);
        lupino.Learn(fire);
        spellSlot1.GetComponent<SpellSlot>().assignedSpell = fire;
        actions.OnHeal += Heal;
        actions.OnDamage += Damage;
        
    }

    private void OnDisable()
    {
        actions.OnHeal -= Heal;
        actions.OnDamage -= Damage;
    }
    public void Damage(int amount)
    {
        lupino.Damage(amount);
        lupino.status = lupino.HealthCheck();
        OnHealthUpdate.Invoke();
    }
    public void Heal(int amount)
    {
        lupino.Heal(amount);
        lupino.status = lupino.HealthCheck();
        OnHealthUpdate.Invoke();
    }

}
