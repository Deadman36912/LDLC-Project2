using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayer : MonoBehaviour
{
    Vector3 SavedPosition;
    Vector3 OriginalPosition;

    // Start is called before the first frame update
    void Start()
    {
        SavedPosition = transform.position;
        OriginalPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Respawn")
        {
            SavedPosition = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < OriginalPosition.y - 2)
        {
            transform.position = SavedPosition;
        }
    }
}
