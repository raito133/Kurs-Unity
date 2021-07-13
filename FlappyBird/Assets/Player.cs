using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float power = 5;
    int points = 0;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(new Vector2(0, Input.GetAxisRaw("Jump")*power));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Point")
        {
            points++;
            GameObject
                .FindGameObjectWithTag("GameManager")
                .GetComponent<GameManager>()
                .SetScore(points);
        }
    }
}
