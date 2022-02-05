using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    public int damageOnCollision = 20;

    public SpriteRenderer graphics;
    private Transform target;
    private int destPoint = 0;

    void Start()
    {
        target = waypoints[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        // Si l'ennemi est quasiment arrivé à sa destination
        if(Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            if (destPoint == 0)
                destPoint = 1;
            else
                destPoint = 0;
            target = waypoints[destPoint];
            graphics.flipX = !graphics.flipX;
            ChangeOffSet(destPoint);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damageOnCollision);
        }
    }

    public void ChangeOffSet(int destpoint)
    {
        Debug.Log("ici");
        if (destpoint == 1)
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(-2, -0);
        else
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(2, -0);
    }
}
