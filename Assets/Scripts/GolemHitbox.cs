using UnityEngine;

public class GolemHitbox : MonoBehaviour
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
        if (active && other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            if (player != null)
            {
                player.TakeDamageOrHeal(-damage); // Example damage value
            }
        }       
    }
}
