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

    private void Awake()
    {
        Health = MaxHealth;
        alreadyAttacked = false;
        if(player == null)
        {
            Debug.LogError("Player reference is not set in the Enemy script.");
        }
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
        Debug.Log($"Enemy Health: {Health}/{MaxHealth}");
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
