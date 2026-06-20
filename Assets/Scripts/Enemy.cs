using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using ML;
using System.Reflection.Emit;

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
    private float Health, aggresivenessWeight = 1f, defenseWeight = 1f, attackWeight = 1f,
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

        double[] input = PlayerAnalytics.Instance.GetLastRecord();
        if(input != null)
        {
            Debug.Log("input: " + input);
            double[] score = Model.Score(input);
            Debug.Log("model inputu:" + string.Join(" | ",  input));
            Debug.Log("model skoru:" + string.Join(" | ",  score));
            UpdateWeights(score);
        }
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

    private void UpdateWeights(double[] probabilities)
    {
        float label0Prob = (float)probabilities[0];
        float label1Prob = (float)probabilities[1];
        float label2Prob = (float)probabilities[2];
        float label3Prob = (float)probabilities[3];

        // label proporties -----------------------------
        float l0_aggW = 1.5f, l0_attW = 0.4f, l0_defW = 1f,
            l1_aggW = 0.6f, l1_attW = 0.3f, l1_defW = 1.7f,
            l2_aggW = 1.2f, l2_attW = 1f, l2_defW = 0.5f,
            l3_aggW = 0.4f, l3_attW = 1.6f, l3_defW = 0.3f;

        // Weights multipliers calculations -------------
        float mult_aggresivenessW = (l0_aggW * label0Prob) + (l1_aggW * label1Prob)
        + (l2_aggW * label2Prob) + (l3_aggW * label3Prob); 

        float mult_attackW = (l0_attW * label0Prob) + (l1_attW * label1Prob)
        + (l2_attW * label2Prob) + (l3_attW * label3Prob); 

        float mult_defenseW = (l0_defW * label0Prob) + (l1_defW * label1Prob)
        + (l2_defW * label2Prob) + (l3_defW * label3Prob); 

        // Applying multipliers to weights --------------
        aggresivenessWeight *= mult_aggresivenessW; 
        attackWeight *= mult_attackW;
        defenseWeight *= mult_defenseW;
        Debug.Log("agresif:" + aggresivenessWeight + " attack:" + attackWeight + " defense:" + defenseWeight);
    }

    private void OnDeath()
    {
        if (Health <= 0)
        {
            PlayerAnalytics.Instance.SaveToCSV(false);
            if(SceneFlow.getLevel() == 3)
            {
                SceneFlow.resetLevel();
                SceneFlow.setMenuState(3);
            }
            else
            {
                SceneFlow.increaseLevel();
                SceneFlow.setMenuState(2);
            }
            SceneManager.LoadScene("Menu");
            Destroy(gameObject);
        }
    }
}