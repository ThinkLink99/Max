// Movement Script
// Author: Trey Hall
// Description:
// Handles player movement and collisions

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxMovement : MonoBehaviour
{
    public float speed = 16f;
    private Rigidbody2D body;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = Vector2.zero;
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.y = Input.GetAxisRaw("Vertical");

        if (velocity != Vector2.zero)
        {
            //Debug.Log("Current Velocity: " + velocity.ToString());
            body.position += velocity * speed * Time.deltaTime;

            animator.SetFloat("Horizontal", velocity.x);
            animator.SetFloat("Vertical", velocity.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }
}
