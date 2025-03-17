using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    private bool isGrounded;


    void FixedUpdate()
    {

        if (Input.GetKey("a"))
        {
            rb.AddForceX(-1000 * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForceX(1000 * Time.deltaTime);
        }

        if (Input.GetKey("space") && isGrounded)
        {
            rb.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}