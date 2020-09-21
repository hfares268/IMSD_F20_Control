﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform myTransform;

    public float speed;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3(5, -5, 0);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //myTransform.position += new Vector3(-1, 1, 0) * speed * Time.deltaTime;
        timer += Time.deltaTime;
        if (timer >= 1)
             {
            timer = 0;
            myTransform.position += new Vector3(-1, 1, 0) * speed;
              }
    }
}
