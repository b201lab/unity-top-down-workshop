using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartByCamera : MonoBehaviour
{
    void Start()
    {
        float height = Camera.main.orthographicSize * 2;
        float width = height * Screen.width/ Screen.height;

        float min = Camera.main.transform.position.x - (width / 2);
        float max = Camera.main.transform.position.x + (width / 2);

        Vector3 position = transform.position;
        position.x = Random.Range(min, max);

        transform.position = position;
    }
}
