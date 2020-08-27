using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotation : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public Sprite[] sprites;
    public float startDirection = 0;
    public float rotation;

    void Start()
    {
      spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
      startDirection = Mathf.Repeat(startDirection, 360);
      float angle = Mathf.Repeat(rotation - startDirection, 360);
      int index = (int)Mathf.Round(angle * sprites.Length / 360);

      // transform.eulerAngles = new Vector3(0, 0, angle);

      if (spriteRenderer != null) {
        spriteRenderer.sprite = sprites[index % sprites.Length];
      }
    }
}
