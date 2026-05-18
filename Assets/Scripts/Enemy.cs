using System;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float MaxHealth, Regeneration, AttackSpeed, MovementSpeed,
     Block, JumpHeight, Damage, Armor, AttackRange, timeBetweenAttacks;
    private float Health;
    private bool alreadyAttacked;
    [SerializeField] private HealthBarUI healthBarUI;

    private void Awake()
    {
        Health = MaxHealth;
        alreadyAttacked = false;
    }

    private void Start()
    {
        healthBarUI.SetMaxHealth(MaxHealth);
        healthBarUI.SetHealth(Health);
    }

    private void Update()
    {
        if(PlayerInAttackRange())
        {
            Attack();
        }
        else
        {
            ChasePlayer();
        }
        RegenerateHealth();
    }

    public void TakeDamageOrHeal(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        healthBarUI.SetHealth(Health);
        healthBarUI.setHealthText();
    }

    private void RegenerateHealth()
    {
        if (Health < MaxHealth)
        {
            TakeDamageOrHeal(Regeneration * Time.deltaTime);
        }
    }

    private void Attack()
    {
        if (!alreadyAttacked)
        {
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);

            player.GetComponent<Player>().TakeDamageOrHeal(-Damage);
        }
    }

    private void ChasePlayer()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * MovementSpeed * Time.deltaTime;
    }

    private bool PlayerInAttackRange()
    {
        float sqrDistance = (player.position - transform.position).sqrMagnitude;
        return sqrDistance <= AttackRange * AttackRange; 
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
