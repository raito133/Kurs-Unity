using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    Rigidbody2D rb;
    Animator animator;
    bool isJumping;
    bool isRunning;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, 
            rb.velocity.y);
        if(!isJumping && Input.GetAxis("Jump") > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x,
            Input.GetAxis("Jump")*10);
            isJumping = true;
        }
        if (rb.velocity.x != 0)
            isRunning = true;
        else
            isRunning = false;
        animator.SetBool("isRunning", isRunning);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" && isJumping==true)
        {
            isJumping = false;
        }
    }
}
