using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController_Bab5 : MonoBehaviour
{
    public static GameObject player;
    public GameObject enemy;
    public int spawnTime;
    private int timer = 0;

    void Start()
    {
        player = GameObject.Find("Player");
        if (player != null)
        {
            Debug.Log("Ketemu");
            Debug.Log(player.GetComponent<PlayerHealth>().startingHealth);
        }
        spawnTime = Random.Range(30, 180);
    }

    void Update()
    {
        timer++;
        if (timer >= spawnTime)
        {
            GameObject spawnedEnemy = Instantiate(enemy, new Vector3(Random.Range(-7f, 7f), -5.9f, 0f), Quaternion.identity);
            spawnedEnemy.GetComponent<EnemyMovement_Bab5>().enemySpeed = Random.Range(1f, 4f);
            spawnedEnemy.GetComponent<EnemyMovement_Bab5>().hp = 2;
            spawnTime = Random.Range(30, 180);
            timer = 0;
        }
    }
}
