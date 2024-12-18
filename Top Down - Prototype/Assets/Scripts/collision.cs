using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
        }

        if (other.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
    }
}
