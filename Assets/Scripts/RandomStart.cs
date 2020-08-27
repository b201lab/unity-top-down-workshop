using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        position.x = Random.Range(-10, 10);

        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
