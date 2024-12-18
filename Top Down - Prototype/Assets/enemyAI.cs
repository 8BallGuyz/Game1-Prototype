using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

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
}
