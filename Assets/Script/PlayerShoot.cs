using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject Projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed primary button.");
            Vector3 position = transform.position + Vector3.up * 0.5f + transform.forward * 0.5f;

            Instantiate(Projectile, position, transform.rotation);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Pressed secondary button.");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Pressed middle click.");
        }
            
    }
}
