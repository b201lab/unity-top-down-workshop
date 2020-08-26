using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement_Bab3 : MonoBehaviour
{
    
    public int hp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerBullet")
        {
            hp--;
        }
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
