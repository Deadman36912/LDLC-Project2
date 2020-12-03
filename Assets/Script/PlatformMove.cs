using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{

    Rigidbody rigidbody;
    [SerializeField]
    Vector3 currentPosition;
    Vector3 direction;
    float speed = 2f;
    [SerializeField]
    int sens = 1;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        currentPosition = transform.position;

        float moveValue = speed * Time.deltaTime;
        //distanceParcourue += moveValue;



        Vector3 newPosition = currentPosition + direction * sens * moveValue;
        rigidbody.MovePosition(newPosition);
    }
}
