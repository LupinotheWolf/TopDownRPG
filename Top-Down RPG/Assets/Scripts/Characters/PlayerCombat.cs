using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    //Object 
    public Transform attackPoint;
    void Update()
    {
        
        if (Input.GetButtonDown("Attack"))
        {
            Attack();
        }
    }
    public void Attack()
    {
        //Attack Animation
        //Create a trigger in animator called Attack to be called in the next line
        //animator.SetTrigger("Attack");

        //Detect enemies nearby
       Collider2D[] hitEnemies =  Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //Damage Enemies
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit: " + enemy.name);
        }
    }
}
