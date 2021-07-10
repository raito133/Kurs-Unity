using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Rigidbody2D rb;
    bool canFire = true;
    float timerBetweenFire = 0.0f;
    [SerializeField]
    GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), rb.velocity.y);
        if(canFire == false)
        {
            timerBetweenFire -= Time.deltaTime;
            if (timerBetweenFire <= 0)
                canFire = true;
        }
        else
        {
            if (Input.GetAxisRaw("Fire1") == 1)
            {
                Instantiate(bulletPrefab, new Vector3(transform.position.x, 
                    transform.position.y + 1,
                    transform.position.z),Quaternion.identity);
            }
            timerBetweenFire = 0.8f;
            canFire = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Alien")
        {
            Destroy(this.gameObject);
        }
    }

}
