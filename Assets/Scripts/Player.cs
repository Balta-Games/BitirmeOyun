using UnityEngine;

public class Player : MonoBehaviour
{
    public float Health, MaxHealth;

    [SerializeField]
    private HealthBarUI healthBarUI;

    private void Start()
    {
        healthBarUI.SetMaxHealth(MaxHealth);
        healthBarUI.SetHealth(Health);
    }
    void Update()
    {
        
    }

    public void TakeDamageOrHeal(float healthChange)
    {
        Health += healthChange;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        healthBarUI.SetHealth(Health);
    }
}
