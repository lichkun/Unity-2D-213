using System;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * 300);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("Walk", true);
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb2d.AddForce(Vector2.right * 5);
                spriteRenderer.flipX = false;
            }
            else
            {
                rb2d.AddForce(Vector2.left * 5);
                spriteRenderer.flipX = true;
            }
        }
        else animator.SetBool("Walk", false);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            rb2d.angularVelocity = 0;
            rb2d.linearVelocity = Vector2.zero;
        }
    }
}
