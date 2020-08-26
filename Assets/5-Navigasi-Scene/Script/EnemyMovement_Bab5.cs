using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement_Bab5 : MonoBehaviour
{
    private bool canShoot;
    private int shootTimer = 0, shootTime;
    private int enemyDirectionIndex;
    private Animator animator;
    private Rigidbody2D rb;
    public GameObject enemyBulletObject;
    public float enemySpeed;
    public float bulletSpawnDistance;
    public int hp;
    public ScoreScript scoreBoard;
    void Start()
    {
        canShoot = true;
        animator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        shootTime = Random.Range(30, 90);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 1.5)
        {
            canShoot = false;
        }
        Vector3 enemyToPlayer = new Vector3(GameController_Bab5.player.transform.position.x - transform.position.x, GameController_Bab5.player.transform.position.y - transform.position.y, 0).normalized;
        enemyDirectionIndex = (int)(((Mathf.Atan2(enemyToPlayer.y, enemyToPlayer.x) * Mathf.Rad2Deg + 360) % 360f + 22.5f) / 45) % 8;
        animator.SetInteger("en_directionID", enemyDirectionIndex);
        rb.velocity = new Vector2(0, enemySpeed);

        shootTimer++;
        if (shootTimer >= shootTime && canShoot)
        {
            Vector3 bulletSpawnPoint = enemyToPlayer.normalized * bulletSpawnDistance + transform.position;
            GameObject spawnedPlayerBullet = Instantiate(enemyBulletObject, bulletSpawnPoint, Quaternion.identity);
            spawnedPlayerBullet.GetComponent<BulletMovement_Bab5>().direction = Mathf.Atan2(enemyToPlayer.y, enemyToPlayer.x) * Mathf.Rad2Deg % 360f;
            spawnedPlayerBullet.GetComponent<BulletMovement_Bab5>().bulletSpeed = Random.Range(enemySpeed + 1f, enemySpeed + 3f);
            shootTime = Random.Range(30, 90);
            shootTimer = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerBullet")
        {
            hp--;
        }
        if (hp <= 0)
        {
            Destroy(this.gameObject);
            scoreBoard = GameObject.Find("Score").GetComponent<ScoreScript>();
            scoreBoard.AddScore(); 
        }
    }

    // void OnTriggerExit2D(Collider2D other)
    // {
    //     gameObject.GetComponent<Collider2D>().isTrigger = false;
    // }
}
