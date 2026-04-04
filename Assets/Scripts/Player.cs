using UnityEngine;

public class Player : MonoBehaviour
{
    private float Health, MaxHealth, Regeneration, AttackSpeed, MovementSpeed,
     Block, JumpHeight, Damage, Armor, AttackRange;
    private int DashNumber, JumpNumber;

    [SerializeField] private HealthBarUI healthBarUI;
    [SerializeField] private PlayerMovement playerMovement;

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
        AttackRange = 2f;
        DashNumber = 1;
        JumpNumber = 1;
    }
    private void Start()
    {
        healthBarUI.SetMaxHealth(MaxHealth);
        healthBarUI.SetHealth(Health);

        playerMovement.SetSpeed(MovementSpeed);
        playerMovement.SetJumpHeight(JumpHeight);
        playerMovement.SetJumpNumber(JumpNumber);
    }
    void Update()
    {
        Attack();
        RegenerateHealth();
    }

    public void TakeDamageOrHeal(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        healthBarUI.SetHealth(Health);
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
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            float attackRange = 2f;

            Vector3 center = transform.position + transform.forward * (attackRange * 0.5f);
            Collider[] hits = Physics.OverlapSphere(center, attackRange);

            foreach (Collider hit in hits)
            {
                var enemy = hit.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamageOrHeal(-Damage);
                }
            }
        }
    }
}
