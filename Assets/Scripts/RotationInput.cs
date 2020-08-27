using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationInput : MonoBehaviour
{
    SpriteRotation spriteRotation;
    // Start is called before the first frame update
    void Start()
    {
      spriteRotation = GetComponent<SpriteRotation>();
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      Vector3 mouseDirection = mousePosition - transform.position;

      float angle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg;

      if (spriteRotation != null) {
        spriteRotation.rotation = angle;
      }
    }
}
