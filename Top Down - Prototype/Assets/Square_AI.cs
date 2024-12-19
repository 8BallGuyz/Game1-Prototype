using UnityEngine;

public class Square_AI : MonoBehaviour
{

    public GameOverScreen gameOverScreen;
    public player_control player_Control;

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

            transform.Rotate(0f, 0f, 90f * Time.deltaTime);
        }
    }
}
