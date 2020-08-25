using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameObject player;
    public GameObject enemy;
    public int spawnTime;
    private int timer=0;

    void Start()
    {
        player = GameObject.Find("Player");
        spawnTime = Random.Range(30, 180);
    }

    void Update()
    {
        timer++;
        if(timer >= spawnTime)
        {
            GameObject spawnedEnemy = Instantiate(enemy, new Vector3(Random.Range(-7f, 7f), -5.9f, 0f), Quaternion.identity);
            spawnedEnemy.GetComponent<EnemyMovement>().enemySpeed = Random.Range(1f, 4f);
            spawnedEnemy.GetComponent<EnemyMovement>().hp = 2;
            spawnTime = Random.Range(30, 180);
            timer = 0;
        }
    }
}
