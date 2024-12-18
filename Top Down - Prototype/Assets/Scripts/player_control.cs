using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class player_control : MonoBehaviour
{
    public float speed;
    public float defaultspeed;
    public float sprintspeed;

    public Camera cam;

    Vector2 MousePos;
    Vector2 movement;

    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        Vector2 LookDir = MousePos - rb.position;
        float angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;

        sprint();
    }

    void sprint()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintspeed;
        }
        else
        {
            speed = defaultspeed;
        }
    }
}
