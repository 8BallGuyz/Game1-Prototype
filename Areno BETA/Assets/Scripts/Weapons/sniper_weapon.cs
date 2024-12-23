using System.Threading;
using UnityEngine;

public class sniper_weapon : MonoBehaviour
{
    public float bulletspeed = 30f;

    public Transform firepoint;
    public GameObject bulletprefab;

    public AudioSource SnipershootSFX;

    private float timer = 0f;
    public float cooldown = 3f;

    void Start()
    {

    }

    void PlayButtonSound()
    {
        SnipershootSFX.Play();
    }

    void Update()
    {
        if (timer < cooldown)
        {
            timer = timer + Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire1") & (timer > cooldown))
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
        SnipershootSFX.Play();
    }
}
