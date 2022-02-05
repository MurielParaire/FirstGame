using UnityEngine;

public class Potion : MonoBehaviour
{
    public int speedGiven;
    public float speedDuration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Deplacementjoueur.instance.AddSpeed(speedGiven, speedDuration);
            Destroy(gameObject);
            
        }
    }
    
}
