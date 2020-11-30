using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePlayer : MonoBehaviour
{

    [SerializeField]
    GameObject Player;
    [SerializeField]
    GameObject CMCamera;
    [SerializeField]
    GameObject MainCamera;
    [SerializeField]
    GameObject FirstPerson;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(Player.activeSelf == false)
        {
            Vector3 SavedPosition = transform.position;
            Player.SetActive(true);
            CMCamera.SetActive(true);
            MainCamera.SetActive(true);
            Player.transform.position = SavedPosition;
            FirstPerson.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
