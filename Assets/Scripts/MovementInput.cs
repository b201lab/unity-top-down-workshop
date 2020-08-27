using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
    public float speed = 1;

    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        Vector2 translation = new Vector2(inputX, inputY);
        translation.Normalize();

        // transform.Translate(translation * Time.deltaTime * speed);

        if (rigidbody2d != null) {
            rigidbody2d.velocity = translation * Time.deltaTime * speed;
        }
    }
}
