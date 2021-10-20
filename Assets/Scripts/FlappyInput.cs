using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyInput : MonoBehaviour
{

    public float flapAmount = 10.0f;
    public Rigidbody2D rb;
    public bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) 
        {
            isPressed = !isPressed;
        }
    }

    private void FixedUpdate()
    {
        if (isPressed)
        {
            flap();
            isPressed = !isPressed;
        }

    }

    void flap()
    {
        rb.velocity = Vector2.up * flapAmount;
    }
    
}
