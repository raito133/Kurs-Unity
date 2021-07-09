using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    int speed = 2;

    [SerializeField]
    bool isPlayer1 = true;

    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer1)
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
}
