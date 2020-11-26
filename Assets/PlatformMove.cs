﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    
    Rigidbody rigidbody;
    bool flag;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        flag = true;
    }

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector3 direction;
        if(flag == true)
        {
            direction = new Vector3(1f, 0f, 0f);
            if(currentPosition.x >= 5.0f)
            {
                flag = false;
            }
        }
        else
        {
            direction = new Vector3(-1f, 0f, 0f);
            if (currentPosition.x <= -4.5f)
            {
                flag = true;
            }
        }

        float speed = 2f;
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;


        rigidbody.MovePosition(newPosition);
    }
}
