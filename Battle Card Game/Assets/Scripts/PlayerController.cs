using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    /*private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 acceleration;

    public float speed;
    public float accelFactor;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Vector2 targetVelocity = speed * movement.normalized;

        acceleration = (targetVelocity - rb.velocity) * (accelFactor / (2 * speed));
    }

    private void FixedUpdate()
    {
        rb.velocity = rb.velocity + acceleration;
    }*/
}
