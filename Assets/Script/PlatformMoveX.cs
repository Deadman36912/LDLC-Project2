using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveX : MonoBehaviour
{
    
    Rigidbody rigidbody;
    bool flag;
    [SerializeField]
    Vector3 currentPosition;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        flag = true;
    }

    void FixedUpdate()
    {
        currentPosition = transform.position;
        Vector3 direction = new Vector3(1f, 0f, 0f);
        
        if(flag == true)
        {
            direction.x = 1f;
            if(currentPosition.x >= 5.0f)
            {
                flag = false;
            }
        }
        else if(flag == false)
        {
            direction.x = -1f;
            if (currentPosition.x <= -5.0f)
            {
                flag = true;
            }
        }
        

        float speed = 2f;
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;


        rigidbody.MovePosition(newPosition);
    }
}
