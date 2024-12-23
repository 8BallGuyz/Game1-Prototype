using System.Threading;
using UnityEngine;

public class pistol_weapon : MonoBehaviour
{
    public float bulletspeed = 20f;

    public Transform firepoint;
    public GameObject bulletprefab;

    private float timer = 0f;
    public float cooldown = 1f;

    void Start()
    {

    }


    void Update()
    {
        if (timer < cooldown)
        {
            timer = timer + Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire1") & (timer>cooldown))
        {
            shoot();
            timer = 0f;
        }
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletspeed, ForceMode2D.Impulse);
    }
}
