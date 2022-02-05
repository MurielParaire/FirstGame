using UnityEngine;

public class Heart : MonoBehaviour
{
    public int HealthGiven;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (PlayerHealth.instance.currentHealth != PlayerHealth.instance.maxHealth)
            {
                PlayerHealth.instance.HealPlayer(HealthGiven);
                Destroy(gameObject);
            }
        }
    }
}