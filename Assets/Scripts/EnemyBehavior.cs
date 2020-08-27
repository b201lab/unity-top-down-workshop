using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject bullet;
    public float shootInterval;

    float time = 0;
    GameObject player;
    SpriteRotation spriteRotation;

    void Start()
    {
        time = shootInterval / 2;
        player = GameObject.Find("Player");
        spriteRotation = GetComponent<SpriteRotation>();
    }

    void Update()
    {
        if (player != null) {
            Vector3 direction = player.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            if (spriteRotation != null) {
                spriteRotation.rotation = angle;
            }

            time += Time.deltaTime;
            if (time > shootInterval) {
                time -= shootInterval;

                if (bullet != null) {
                    Vector3 eulerAngles = transform.eulerAngles;
                    eulerAngles.z = angle;

                    Instantiate(bullet, transform.position, Quaternion.Euler(eulerAngles));
                }
            }
        }
    }
}
