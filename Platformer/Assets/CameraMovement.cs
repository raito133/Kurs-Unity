using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float smoothTime = 0.3f;
    Vector3 velocity = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.SmoothDamp(
            transform.position,
            new Vector3(
            player.position.x,
            player.position.y,
            transform.position.z),
            ref velocity,
            smoothTime
            );
    }
}
