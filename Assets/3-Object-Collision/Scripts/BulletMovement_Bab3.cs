using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement_Bab3 : MonoBehaviour
{
    private bool isHit;
    private Animator animator;
    private Rigidbody2D rb;
    public float bulletSpeed, direction;

    void Start()
    {
        isHit = false;
        animator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isHit == false)
        {
            rb.velocity = new Vector2(Mathf.Cos(Mathf.Deg2Rad * direction), Mathf.Sin(Mathf.Deg2Rad * direction)) * bulletSpeed;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isHit == false)
        {
            if (this.gameObject.tag == "PlayerBullet")
            {
                if (other.tag != "Player" && other.tag != "EnemyBullet" && other.tag != "PlayerBullet")
                {
                    // Destroy(this.gameObject);
                    isHit = true;
                    rb.velocity = Vector2.zero;
                    animator.SetBool("isHit", isHit);
                }
            }
        }
    }

    public void DestroyOnDisappear()
    {
        Destroy(this.gameObject);
    }
}
