using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    int speed = 5;
    int health = 1;
    int startingHealth = 1;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject
            .FindGameObjectWithTag("GameManager")
            .GetComponent<GameManager>();

        health = Random.Range(1, 4);
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (health == 2)
            spriteRenderer.color = Color.cyan;
        else if (health == 3)
            spriteRenderer.color = Color.green;
        startingHealth = health;

    }
    private void Update()
    {
        transform.position = new Vector2(transform.position.x + 1 * speed * Time.deltaTime, transform.position.y);
    }

    void FixedUpdate()
    {
        //transform.position = new Vector2(transform.position.x + 1, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            transform.position = new Vector2(-4, transform.position.y - 1);
        }
        if(collision.gameObject.tag == "Bullet")
        {
            health--;
            if(health <= 0)
            {
                Destroy(this.gameObject); // usuniêcie kosmity
                                          // w przypadku zdrowia równego 0
                gameManager.IncreaseScore(startingHealth); // zdrowie kosmity 3 
                                             // doda³o 3 punkty

            }
            Destroy(collision.gameObject); // usuniêcie pocisku
        }
    }
}
