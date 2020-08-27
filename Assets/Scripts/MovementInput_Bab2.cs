using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput_Bab2 : MonoBehaviour
{
    private Rigidbody2D rb;
    private int directionID;
    private Animator animator;
    private Vector3 mouseScreenToWorld, mouseToPlayer;
    public float speed = 5f;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Dapatkan nilai input dari keyboard
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        // Gunakan nilai yang telah didapatkan untuk menggerakkan pemain
        //Input axis are normalized to ensure every possible movements are in the same speed
        Vector3 movement = new Vector3(inputX, inputY, 0f).normalized;
        mouseScreenToWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseToPlayer = (mouseScreenToWorld - transform.position);
        directionID = (int)(((Mathf.Atan2(mouseToPlayer.y, mouseToPlayer.x) * Mathf.Rad2Deg + 360) % 360f + 22.5f) / 45) % 8;

        // Atur animasi dan gerakkan pemain
        animator.SetInteger("directionIndex", directionID);
        rb.velocity = new Vector2(movement.x, movement.y) * speed;
        // transform.Translate(movement * speed * Time.deltaTime);

    }
}
