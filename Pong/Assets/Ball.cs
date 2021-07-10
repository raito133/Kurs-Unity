using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidbody;
    Vector3 startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(RandomVelocity(), RandomVelocity());
    }

    int RandomVelocity()
    {
        int number = Random.Range(0, 2);
        if (number == 0)
            return -5;
        else
            return 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Edge")
        {
            transform.position = startingPosition;
            rigidbody.velocity = new Vector2(RandomVelocity(), RandomVelocity());
        }
    }
}
