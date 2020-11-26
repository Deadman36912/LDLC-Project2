using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayer : MonoBehaviour
{
    Vector3 SavedPosition;


    // Start is called before the first frame update
    void Start()
    {
        SavedPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < SavedPosition.y - 2)
        {
            transform.position = SavedPosition;
        }
        
    }
}
