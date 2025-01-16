using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public player_control player_Control;

    public float speed = 3;
    public Rigidbody2D rb;

    public int Lives = 2;

    private GameObject target;  // Instead of directly referencing the player
    private float distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Find the GameObject with the tag "follow"
        target = GameObject.FindGameObjectWithTag("follow");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target != null)
        {
            distance = Vector2.Distance(transform.position, target.transform.position);
            Vector2 direction = target.transform.position - transform.position;

            // Move towards the target
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

            Rotation();
        }
    }

    void Rotation()
    {
        if (target != null)
        {
            Vector2 lookDir = transform.position - target.transform.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 45f;
            rb.rotation = angle;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            TakeDamageAR();
            Destroy(collision.gameObject); // Destroy the bullet on impact
        }
        if (collision.gameObject.CompareTag("sniper_bullet"))
        {
            TakeDamageSniper();
            Destroy(collision.gameObject); // Destroy the bullet on impact
        }
    }

    public void TakeDamageAR()
    {
        Lives = Lives - 1;

        if (Lives <= 0)
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
    }

    public void TakeDamageSniper()
    {
        Lives = Lives - 2;

        if (Lives <= 0)
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }
    }
}
