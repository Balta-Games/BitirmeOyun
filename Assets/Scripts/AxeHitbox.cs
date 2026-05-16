using UnityEngine;

public class AxeHitbox : MonoBehaviour
{
    private bool active;
    private float damage;

    private void Awake()
    {
        active = false;
    }

    public void SetDamage(float damage)
    {
        this.damage = damage;
    }

    public void SetActive(bool active)
    {
        this.active = active;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active && other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamageOrHeal(-damage); // Example damage value
            }
        }       
    }
}
