using UnityEngine;

public class bulletdestroy : MonoBehaviour
{
    public float timer = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
