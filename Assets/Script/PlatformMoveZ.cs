using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveZ : MonoBehaviour
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
        Vector3 direction = new Vector3(0f, 0f, 1f);
        if (flag == true)
        {
            direction.z = 1f;
            if (currentPosition.z >= 30)
            {
                flag = false;
            }
        }
        else if (flag == false)
        {
            direction.z = -1f;
            if (currentPosition.z <= 24)
            {
                flag = true;
            }
        }

        float speed = 2f;
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;


        rigidbody.MovePosition(newPosition);
    }
}