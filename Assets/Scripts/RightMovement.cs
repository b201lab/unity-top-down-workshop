using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovement : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rigidbody2d;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (rigidbody2d != null) {
            rigidbody2d.velocity = transform.right * Time.deltaTime * speed;
        }
    }
}
