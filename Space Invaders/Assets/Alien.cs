using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    int speed = 1;
    int health = 1;
    // Start is called before the first frame update
    void Start()
    {
        
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
            ///odjêcie zdrowia, sprawdzenie zdrowia i usuniêcie
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            
        }
        Debug.Log("Wall hit");
    }
}
