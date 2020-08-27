using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovement : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
      rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    // void Update()
    void FixedUpdate()
    {
        // Vector3 translation = new Vector3(0, 5, 0);

        // transform.Translate(translation * Time.deltaTime);
        if (rigidbody2d != null) {
            rigidbody2d.velocity = transform.right * Time.deltaTime * speed;
        }
    }
}
