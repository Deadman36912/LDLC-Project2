using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRotation : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var rotationVector = transform.rotation.eulerAngles;  
        rotationVector.z = 1;
        transform.rotation = Quaternion.Euler(rotationVector);
    }
}
