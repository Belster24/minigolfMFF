using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Ball;
    public Text scoreText;
    public int score;

    void Start()
    {
        score = 0;
    }

    

    void Update()
    {

        if (Input.GetMouseButtonUp(0))
        {

            score += 1;

        }

        

        scoreText.text = "Score: " + score;

        
    }
}
