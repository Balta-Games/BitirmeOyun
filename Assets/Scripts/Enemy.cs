using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public enum BossAction
    {
        None,
        Swipe,
        AOE,
        Dodge,
        Block,
    }
    public enum ActionCategory
    {
        Attack,
        Defense,
    }
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
    private BossAction lastAction = BossAction.None;
    private bool canUseAOE = true;
    private bool isThinking = false;
    [SerializeField] private float thinkTime = 1.5f;
    private float aggresivenessWeight = 1.8f;
    private float defenseWeight = 0.2f;
    private float attackWeight = 2f;
    private bool isDodging = false;
    private float dodgeDistance = 6f;
    private float dodgeDuration = 0.375f;
    [SerializeField] private float blockDuration = 3f;
    private bool isBlocking = false;
    [SerializeField] private GolemHitbox golemArmHitbox;
    [SerializeField] private GolemHitbox golemAOEHitbox;

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
        golemArmHitbox.SetDamage(Damage);
        golemAOEHitbox.SetDamage(Damage);
    }

    private void Update()
    {
        if (isBlocking || isDodging)
            return;

        if (PlayerInAttackRange())
        {
            isWalking = false;
            animator.SetBool("isWalking", false);

            if (!alreadyAttacked && !isThinking)
            {
                StartCoroutine(ThinkAndAct());
            }
        }
        else
        {
            if (!alreadyAttacked)
            {
                ChasePlayer();
            }
        }

        RegenerateHealth();
    }
    private ActionCategory DecideCategory()
    {
        float normalLimit = 50f;
        float roll = UnityEngine.Random.Range(0f, 100f);

        if (roll < normalLimit * aggresivenessWeight)
            return ActionCategory.Attack;
        else
            return ActionCategory.Defense;
    }

    private BossAction DecideAction()
    {
        ActionCategory category = DecideCategory();
        float roll = UnityEngine.Random.Range(0f, 100f);

        if (category == ActionCategory.Attack)
        {
            if (roll < 50f * attackWeight)
                return BossAction.Swipe;
            else
                return BossAction.AOE;
        }
        else
        {
            if (roll < 50f * defenseWeight)
                return BossAction.Block;
            else
                return BossAction.Dodge;
        }
    }

    private void ExecuteAction(BossAction action)
    {
        switch (action)
        {
            case BossAction.Swipe:
                Attack();
                break;
            case BossAction.AOE:
                AOEAttack();
                break;
            case BossAction.Block:
                StartCoroutine(BlockRoutine());
                break;
            case BossAction.Dodge:
                Dodge();
                break;
        }

        lastAction = action;
    }

    private IEnumerator ThinkAndAct()
    {
        isThinking = true;
        yield return new WaitForSeconds(thinkTime);
        BossAction action = DecideAction();
        ExecuteAction(action);
        isThinking = false;
    }

    public void TakeDamageOrHeal(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        healthBarUI.SetHealth(Health);
        healthBarUI.setHealthText();
        OnDeath();
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
            golemArmHitbox.SetActive(true);
        }
    }

    private void AOEAttack()
    {
        if (!alreadyAttacked)
        {
            if(!canUseAOE)
                return;

            StartCoroutine(AOECooldown());
            AoeAttackObject.SetActive(true);
            StartCoroutine(GrowHitbox());
            alreadyAttacked = true;
            animator.SetTrigger("isAOEAttacked");
            golemAOEHitbox.SetActive(true);
        }
    }

    public void closeGolemHitbox()
    {
        golemArmHitbox.SetActive(false);
    }
    public IEnumerator AOECooldown()
    {
        canUseAOE = false;

        yield return new WaitForSeconds(8f);

        canUseAOE = true;
    }
    private IEnumerator BlockRoutine()
    {
        isBlocking = true;

        animator.SetBool("isBlocking", true);
        animator.SetTrigger("blockStarted");

        yield return new WaitForSeconds(3f);

        animator.SetBool("isBlocking", false);

        isBlocking = false;

        StartCoroutine(ThinkAndAct());
    }
    public void Dodge()
    {
        if(isDodging)
            return;


        animator.SetTrigger("isDodging");
        StartCoroutine(DodgeMovement());
    }

    private IEnumerator DodgeMovement()
    {
        isDodging = true;
        Vector3 startPos = transform.position;
        Vector3 targetPos = startPos + transform.right * dodgeDistance;

        float elapsed = 0f;

        while (elapsed < dodgeDuration)
        {
            elapsed += Time.deltaTime;

            transform.position = Vector3.Lerp(
                startPos,
                targetPos,
                elapsed / dodgeDuration
            );

            yield return null;
        }

        transform.position = targetPos;
        isDodging = false;
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
        if (isDodging)
            return;
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
        golemAOEHitbox.SetActive(false);
    }

    private void OnDeath()
    {
        if (Health <= 0)
        {
            SceneFlow.setMenuState(2);
            SceneManager.LoadScene("Menu");
            Destroy(gameObject);
        }
    }
}