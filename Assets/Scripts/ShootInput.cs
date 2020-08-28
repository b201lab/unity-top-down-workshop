using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootInput : MonoBehaviour
{
    public GameObject bullet;
    public float reloadTime;

    float time;

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0 && Input.GetButtonDown("Fire1")) {
            time = reloadTime;

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 mouseDirection = mousePosition - transform.position;

            float angle = Mathf.Atan2(mouseDirection.y, mouseDirection.x) * Mathf.Rad2Deg;

            Vector3 eulerAngles = transform.eulerAngles;
            eulerAngles.z = angle;

            Instantiate(bullet, transform.position, Quaternion.Euler(eulerAngles));
        }
    }
}
