using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dropper : MonoBehaviour
{
    public float fallSpeed = 10f;
    public Transform hole;
    public Transform ball;
    private Score score;


    private void Start()
    {
        score = FindObjectOfType<Score>();
    }


    private void Update()
    {

        if (ball.position.y < -5f)
        {
            ball.position = Vector3.zero;




        }

    }

    
    void OnTriggerEnter(Collider other)
    {

      
        
        if (other.gameObject.tag == "Player")
        {



            other.gameObject.transform.position = hole.position;
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;


            score.score = 0;
        }
    }
}
