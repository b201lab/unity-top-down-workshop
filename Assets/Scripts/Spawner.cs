using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnInterval = 1;

    float time = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= spawnInterval) {
            time -= spawnInterval;

            if (prefab != null) {
                Instantiate(prefab, transform.position, transform.rotation);
            }
        }
    }
}
