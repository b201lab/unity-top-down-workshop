﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translation = new Vector3(0, 5, 0);
        transform.Translate(translation * Time.deltaTime);
    }
}
