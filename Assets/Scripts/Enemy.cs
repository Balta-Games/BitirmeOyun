using System;
using System.Collections;
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
    [SerializeField] private GameObject AoeAttackObject;
    private SphereCollider AoeHitBox;
    [SerializeField] private float maxRadius = 4f;
    [SerializeField] private float growDuration = 1f;
    private Animator animator;
    private bool isWalking;

    private void Awake()
    {
        Health = MaxHealth;
        alreadyAttacked = false;
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        AoeAttackObject.SetActive(false);
        AoeHitBox = AoeAttackObject.GetComponent<SphereCollider>();
        AoeHitBox.radius = 0f;
        healthBarUI.SetMaxHealth(MaxHealth);
        healthBarUI.SetHealth(Health);
    }

    private void Update()
    {
        if(PlayerInAttackRange())
        {
            isWalking = false;
            animator.SetBool("isWalking", isWalking);
            int randomAttack = UnityEngine.Random.Range(0, 2);
            Debug.Log(randomAttack);
            if (randomAttack == 0)
            {
                Attack();
            }
            else
            {
                AOEAttack();
            }
        }
        else
        {
            if(!alreadyAttacked)
            {
                ChasePlayer();
            }
            
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
            animator.SetTrigger("isSwiped");
            //Invoke(nameof(ResetAttack), timeBetweenAttacks);

            player.GetComponent<Player>().TakeDamageOrHeal(-Damage);
        }
    }

    private void AOEAttack()
    {
        if (!alreadyAttacked)
        {
            AoeAttackObject.SetActive(true);
            StartCoroutine(GrowHitbox());
            alreadyAttacked = true;
            animator.SetTrigger("isAOEAttacked");
            //Invoke(nameof(ResetAttack), timeBetweenAttacks);

            player.GetComponent<Player>().TakeDamageOrHeal(-Damage);
        }
    }

     private IEnumerator GrowHitbox()
    {
        float timer = 0f;

        AoeHitBox.radius = 0f;

        while (timer < growDuration)
        {
            timer += Time.deltaTime;

            float t = timer / growDuration;

            AoeHitBox.radius = Mathf.Lerp(0f, maxRadius, t);

            yield return null;
        }

        AoeHitBox.radius = maxRadius;

        AoeHitBox.radius = 0f;

        AoeAttackObject.SetActive(false);
    }

    private void ChasePlayer()
    {
        isWalking = true;
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * MovementSpeed * Time.deltaTime;

        Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            targetRotation,
            Time.deltaTime * 500f
        );
        animator.SetBool("isWalking", isWalking);
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
