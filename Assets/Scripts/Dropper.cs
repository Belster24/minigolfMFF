using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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


    
        levels[0].lvlText.text = PlayerPrefs.GetString("Score1");
        levels[1].lvlText.text = PlayerPrefs.GetString("Score2");
        levels[2].lvlText.text = PlayerPrefs.GetString("Score3");
        levels[3].lvlText.text = PlayerPrefs.GetString("Score4");
        levels[4].lvlText.text = PlayerPrefs.GetString("Score5");


    }


    void OnTriggerEnter(Collider other)
    {

      
        
        if (other.gameObject.tag == "Player")
        {



            other.gameObject.transform.position = hole.position;
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

            FindObjectOfType<AudioManager>().Play("Ball_In_Hole");



           
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                PlayerPrefs.SetString("Score1", Convert.ToString(score.score));
                

            }
            else if(SceneManager.GetActiveScene().buildIndex == 2)
            {
                PlayerPrefs.SetString("Score2", Convert.ToString(score.score));

            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                PlayerPrefs.SetString("Score3", Convert.ToString(score.score));

            }
            else if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                PlayerPrefs.SetString("Score4", Convert.ToString(score.score));

            }
            else if (SceneManager.GetActiveScene().buildIndex == 5)
            {
                PlayerPrefs.SetString("Score5", Convert.ToString(score.score));

            }



            score.score = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
    
    

