using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
  private Animator animator;
  public float speed = 5f;

  void Start()
  {
    animator = gameObject.GetComponent<Animator>();
  }

  void Update()
  {
    float inputX = Input.GetAxis("Horizontal");
    float inputY = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(inputX, inputY, 0f);

    transform.Translate(movement * speed * Time.deltaTime);

    if (animator != null) {
      animator.SetBool("idle", movement.magnitude <= 0f);
      animator.SetFloat("move_x", movement.x);
    }
  }
}
