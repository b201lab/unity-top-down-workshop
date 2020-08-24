using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float bulletSpeed, direction;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Mathf.Cos(Mathf.Deg2Rad * direction), Mathf.Sin(Mathf.Deg2Rad * direction)) * bulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag!="Player")
        {
            Destroy(this.gameObject);
        }
    }
}
