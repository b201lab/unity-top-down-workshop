using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
  private int directionID;
  private Animator animator;
  private Vector3 mouseScreenToWorld, mouseToPlayer;
  public float speed = 5f;

  void Start()
  {
    animator = gameObject.GetComponent<Animator>();
  }

  void Update()
  {
    float inputX = Input.GetAxisRaw("Horizontal");
    float inputY = Input.GetAxisRaw("Vertical");
    
    //Input axis are normalized to ensure every possible movements are in the same speed
    Vector3 movement = new Vector3(inputX, inputY, 0f).normalized;
    mouseScreenToWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mouseToPlayer = (mouseScreenToWorld - transform.position);
    directionID = (int)((((Mathf.Atan2(mouseToPlayer.y, mouseToPlayer.x) * Mathf.Rad2Deg)+360f)%360 + 22.5f)/ 45)%8;
    Debug.Log((Mathf.Atan2(mouseToPlayer.y, mouseToPlayer.x) * Mathf.Rad2Deg + 360f)%360 + ", "+directionID + "("+ mouseToPlayer.x + ", "+mouseToPlayer.y+")");
    Debug.DrawLine(transform.position, mouseScreenToWorld, Color.red);
    // animator.SetFloat("moveHori", movement.x);
    // animator.SetFloat("moveVert", movement.y);
    animator.SetInteger("directionIndex", directionID);

    transform.Translate(movement * speed * Time.deltaTime);
  }
}
