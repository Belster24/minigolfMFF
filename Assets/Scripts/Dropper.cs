using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dropper : MonoBehaviour
{
    public float fallSpeed = 10f;
    public Transform hole;
    public Transform ball;
    public Score score;


    private void Update()
    {
        
        if(ball.position.y < -5f)
        {
            ball.position = Vector3.zero;

          

        }

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("Ahoj jsem tu");
            
            other.gameObject.transform.position = hole.position;
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

           
        }
    }
}
