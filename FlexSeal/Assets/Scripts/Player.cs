using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour { 

private Rigidbody2D rb;
public float speed, jumpForce;
public KeyCode left, right, jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKey(jump))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
