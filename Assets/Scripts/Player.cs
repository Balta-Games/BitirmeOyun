using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private float Health, MaxHealth, Regeneration, AttackSpeed, MovementSpeed,
     Block, JumpHeight, Damage, Armor, AttackRange;
    private int DashNumber, JumpNumber;

    [SerializeField] private HealthBarUI healthBarUI;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private AxeHitbox axeHitbox;

    private void Awake()
    {
        MaxHealth = 100f;
        Health = MaxHealth;
        Regeneration = 1f;
        AttackSpeed = 1f;
        MovementSpeed = 5f;
        Block = 0.2f;
        JumpHeight = 6f;
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

        axeHitbox.SetDamage(Damage);
    }
    void Update()
    {
        RegenerateHealth();
    }

    public void TakeDamageOrHeal(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        healthBarUI.SetHealth(Health);
        OnDeath();
    }

    private void RegenerateHealth()
    {
        if (Health < MaxHealth)
        {
            TakeDamageOrHeal(Regeneration * Time.deltaTime);
        }
    }

    private void OnDeath()
    {
        if (Health <= 0)
        {
            SceneFlow.setMenuState(1);
            SceneManager.LoadScene("Menu");
        }
    }
}
