using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    bool isJumping;
    bool isRunning;
    bool isFalling;
    int appleCount = 0;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //nadanie postaci prêdkoœci
        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, 
            rb.velocity.y);
        //sterowanie obrotem postaci
        if (Input.GetAxisRaw("Horizontal") == 1)
            spriteRenderer.flipX = false;
        else if(Input.GetAxisRaw("Horizontal") == -1)
            spriteRenderer.flipX = true;
        //sterowanie skokiem
        if (!isJumping && Input.GetAxis("Jump") > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x,
            Input.GetAxis("Jump")*10);
            isJumping = true;
        }
        //sprawdzanie czy biegniemy
        if (rb.velocity.x != 0)
            isRunning = true;
        else
            isRunning = false;
        //sprawdzanie czy spada
        if (isJumping && rb.velocity.y < 0)
            isFalling = true;
        else
            isFalling = false;
        // ustawianie zmiennych stanu na koñcu Update()
        animator.SetBool("isRunning", isRunning);
        animator.SetBool("isJumping", isJumping);
        animator.SetBool("isFalling", isFalling);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground" && isJumping==true)
        {
            isJumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fruit")
        {
            appleCount++;
            gameManager.SetAppleScore(appleCount);
            Destroy(collision.gameObject);
        }
    }
}
