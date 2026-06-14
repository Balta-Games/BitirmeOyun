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
     Block, Damage, AttackRange, timeBetweenAttacks, maxRadius = 4f,
     growDuration = 3f, thinkTime = 1.5f, blockDuration = 3f;
    private float Health, aggresivenessWeight = 1f, defenseWeight = 1f, attackWeight = 0.2f,
     dodgeDistance = 6f, dodgeDuration = 0.375f;
    private bool alreadyAttacked, isWalking, canUseAOE = true, isThinking = false,
     isDodging = false, isBlocking = false;
    [SerializeField] private HealthBarUI healthBarUI;
    [SerializeField] private GameObject AoeAttackObject;
    private SphereCollider AoeHitBox;
    private Animator animator;
    private BossAction lastAction = BossAction.None;
    [SerializeField] private GolemHitbox golemArmHitbox, golemAOEHitbox;
    private bool firstActionOnEngage = true;

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
                if(firstActionOnEngage)
                {
                    firstActionOnEngage = false;
                    BossAction action = DecideAction();
                    ExecuteAction(action); 
                }
                else
                {
                    StartCoroutine(ThinkAndAct());
                }
                
            }
        }
        else
        {
            if (!alreadyAttacked)
            {
                ChasePlayer();
            }
        }

        //RegenerateHealth();
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
        if((!isBlocking && !isDodging) || healthChange > 0)
        {
            Health += healthChange;
        }
        else if(isBlocking && healthChange < 0)
        {
            Health += healthChange * (1 - Block);
        }
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

        float timer = 0f;

        while (timer < blockDuration)
        {
            if (!PayerInBlockRange())
                break;

            timer += Time.deltaTime;
            yield return null;
        }

        animator.SetBool("isBlocking", false);
        isBlocking = false;

        if (PlayerInAttackRange())
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
        if (PlayerInAttackRange())
        {
            isWalking = false;
            animator.SetBool("isWalking", false);
            return;
        }
        firstActionOnEngage = true;
        isWalking = true;
        Vector3 direction = (player.position - transform.position).normalized;
        direction.y = 0;
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
    private bool PayerInBlockRange()
    {
        float sqrDistance = (player.position - transform.position).sqrMagnitude;
        return sqrDistance <= (AttackRange + 2f) * (AttackRange + 2f);
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
        golemAOEHitbox.SetActive(false);
    }
    private void OpenHitBox()
    {
        golemArmHitbox.SetActive(true);
    }

    private void OnDeath()
    {
        if (Health <= 0)
        {
            PlayerAnalytics.Instance.SaveToCSV(false);
            SceneFlow.setMenuState(2);
            SceneManager.LoadScene("Menu");
            Destroy(gameObject);
        }
    }
}