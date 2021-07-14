using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float speed= 5;
    [SerializeField] float rotationSpeed = 5;
    [SerializeField] GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector3(Input.GetAxisRaw("Horizontal")*speed, 
            rigidbody.velocity.y,
            Input.GetAxisRaw("Vertical")*speed);

        //transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * rotationSpeed);

        //new Quaternion(
        //Input.GetAxis("Mouse X") + rigidbody.rotation.x,
        //rigidbody.rotation.y, 
        //Input.GetAxis("Mouse Y") + rigidbody.rotation.z, 
        //rigidbody.rotation.w);

        if (Input.GetAxisRaw("Jump") == 1)
            Instantiate(bulletPrefab);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
            Destroy(this.gameObject);
    }
}
