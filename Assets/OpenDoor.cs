using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    GameObject doorObject;
    float timer;
    float timer2;

    private void OnTriggerEnter(Collider other)
    {
        doorObject.SetActive(false);
        timer = 5.0f;
        timer2 = 0.0f;
    }

    private void OnTriggerStay(Collider other)
    {
        //doorObject.SetActive(false);
        //Debug.Log("Il y a collision avec " + other.gameObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        doorObject.SetActive(true);
    }
    private void Update()
    {
        if(timer2 > timer)
        {
            doorObject.SetActive(true);
        }
        timer2 += Time.deltaTime;
    }
}
