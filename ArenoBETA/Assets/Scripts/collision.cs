using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject); // Destroy the bullet on impact
        }
            if (collision.gameObject.CompareTag("sniper_bullet"))
        {
            Destroy(collision.gameObject); // Destroy the bullet on impact
        }
    }
}
