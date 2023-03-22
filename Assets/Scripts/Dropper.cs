using System;
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

    public Levels[] levels;

    private string namef;


    
    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    //When the ball enters the hole, reset the ball to the starting position and set score to 0
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

            FindObjectOfType<AudioManager>().Play("Ball_In_Hole");

            
            foreach (Levels l in levels)
              {
                if (l.name == "Level"+ SceneManager.GetActiveScene().buildIndex)
               {
                            l.lvlText.text = Convert.ToString(score.score);
                            namef = l.lvlText.text;
                }
             }
                    
                


            score.score = 0;

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
