using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    
    public Transform TeleportEnd;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {


          other.gameObject.transform.position = TeleportEnd.position;


            
        }
    }
}


