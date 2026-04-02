using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float Health, MaxHealth, Regeneration, AttackSpeed, MovementSpeed,
     Block, JumpHeight, Damage, Armor;

    private void Awake()
    {
        MaxHealth = 100f;
        Health = MaxHealth;
        Regeneration = 1f;
        AttackSpeed = 1f;
        MovementSpeed = 5f;
        Block = 0.2f;
        JumpHeight = 4f;
        Damage = 10f;
        Armor = 0.1f;
    }

    public void TakeDamageOrHeal(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        Debug.Log($"Enemy Health: {Health}/{MaxHealth}");
    }
}
