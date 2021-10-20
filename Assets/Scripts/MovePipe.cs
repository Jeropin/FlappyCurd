using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        rb.velocity = Vector2.left * speed;
    }
}
    