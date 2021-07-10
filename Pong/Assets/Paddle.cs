using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    int speed = 2;

    [SerializeField]
    bool isPlayer1 = true;

    [SerializeField]
    bool isHuman = true;

    float timer = 0.0f;

    Vector2 startingPosition;

    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(isHuman)
        {
            if (isPlayer1)
            {
                this.rigidbody.velocity = new Vector2(rigidbody.velocity.x,
                Input.GetAxisRaw("Vertical") * speed);
            }
            else
            {
                this.rigidbody.velocity = new Vector2(rigidbody.velocity.x,
                Input.GetAxisRaw("Vertical2") * speed);
            }
        }
        else if(timer < 2.0f)
        {
            Vector2 ballPosition = GameObject.FindGameObjectWithTag("Ball").transform.position;
            if (ballPosition.y > transform.position.y)
            {
                this.rigidbody.velocity = new Vector2(rigidbody.velocity.x,
                1 * speed);
            }
            else if (ballPosition.y < transform.position.y)
            {
                this.rigidbody.velocity = new Vector2(rigidbody.velocity.x,
                -1 * speed);
            }
            else
            {
                this.rigidbody.velocity = new Vector2(rigidbody.velocity.x,
                0);
            }
        }
        if (timer >= 4.0f)
            timer = 0.0f;
    }
}
