using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetBall : MonoBehaviour
{
    //Restart the ball to the starting position
    public Vector3 lastBallPosition;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            lastBallPosition = other.gameObject.transform.position;
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            
        }
    }

    public void BallReset()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball != null)
        {
            ball.transform.position = lastBallPosition;

           ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
