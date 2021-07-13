using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] float speed = 1;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - 1 *Time.deltaTime * speed, transform.position.y);
        if (transform.position.x <= -3)
            transform.position = new Vector2(15, Random.Range(-2, 3));
    }
}
