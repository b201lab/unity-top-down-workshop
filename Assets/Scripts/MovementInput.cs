using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      float inputX = Input.GetAxisRaw("Horizontal");
      float inputY = Input.GetAxisRaw("Vertical");

      Vector3 translation = new Vector3(inputX, inputY, 0);
      translation.Normalize();

      transform.Translate(translation * Time.deltaTime * speed);
    }
}
