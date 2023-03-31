using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Ball;
    public Text scoreText;
    public int score = 0;



    void Start()
    {
        score = 0;
    }

    

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Rigidbody rb = player.GetComponent<Rigidbody>();


        if (Input.GetMouseButtonUp(0) && rb.velocity.magnitude < 1f)
        {

            score += 1;

        }

        

        scoreText.text = "Uder: " + score;

        if(score >= 2)
        {
            scoreText.text = "Uderu: " + score;
        }

        
    }
}
