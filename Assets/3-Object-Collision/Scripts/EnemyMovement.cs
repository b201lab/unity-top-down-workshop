using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private int enemyDirectionIndex;
    private Animator animator;
    private Rigidbody2D rb;
    public float enemySpeed;
    public int hp;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayer = new Vector2(GameController.player.transform.position.x-transform.position.x, GameController.player.transform.position.y-transform.position.y).normalized;
        enemyDirectionIndex = (int)((((Mathf.Atan2(enemyToPlayer.y, enemyToPlayer.x) * Mathf.Rad2Deg))%360 + 22.5f)/ 45)%8;

        animator.SetInteger("en_directionID", enemyDirectionIndex);
        rb.velocity = new Vector2(0, enemySpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            hp--;
        }
        if(hp<=0)
        {
             Destroy(this.gameObject);
        }
    }

    // void OnTriggerExit2D(Collider2D other)
    // {
    //     gameObject.GetComponent<Collider2D>().isTrigger = false;
    // }
}
