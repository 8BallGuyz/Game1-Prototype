using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy_spawner : MonoBehaviour
{
    public GameObject enemy;
    public player_control player_Control;

    public float StartDelay = 2f;
    public float Repeat = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", StartDelay, Repeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}
