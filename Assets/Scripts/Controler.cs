using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    float xRot, yRot = 0f;

    public Rigidbody rb;

    public float rotationSpeed = 5f;

    private Vector2 touchStart, touchEnd;

    private float shootPower = 30f;
    private float holdTime = 0f;
    //private float maxHoldTime = 3f;

    public LineRenderer line;

    private int numCollisions = 0;
    private float velocityDecrease = 0.08f;
    private float angularVelocityDecrease = 0.02f;
    private float decreaseInterval = 0.5f;
    private float timeSinceDecrease = 0f;

    Touch touch;

    void Update()
    {
        transform.position = rb.position;
        //when button is clicked down get ready to aim

        if (Application.platform == RuntimePlatform.Android)
        {

            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    touchStart = touch.position;

                }else if(touch.phase == TouchPhase.Moved) { 
                     //xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                    //yRot -= Input.GetAxis("Mouse Y") * rotationSpeed;
                    
                    touchEnd = touch.position;

                    xRot = touchEnd.x - touchStart.x;
                    yRot = touchEnd.y - touchStart.y;


                    if (yRot < -14f)
                    {
                        yRot = -14f;
                    }
                    if (yRot > 30f)
                    {
                        yRot = 30f;
                    }

                    transform.rotation = Quaternion.Euler(yRot, xRot, 0f);

                    line.gameObject.SetActive(true);
                    line.SetPosition(0, transform.position);
                    line.SetPosition(1, transform.position + transform.forward * 4f);

                    holdTime += Time.deltaTime;
                    shootPower = Mathf.Clamp(holdTime * 10f, 30f, 300f);

                }

                if(touch.phase == TouchPhase.Ended)
                {
                    FindObjectOfType<AudioManager>().Play("BallHit");
                    rb.velocity = transform.forward * shootPower;
                    numCollisions = 0;
                    line.gameObject.SetActive(false);
                    holdTime = 0f;
                }
               
            }

           


        }
        else{
            if (Input.GetMouseButton(0))
            {
                xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                yRot -= Input.GetAxis("Mouse Y") * rotationSpeed;

                if (yRot < -14f)
                {
                    yRot = -14f;
                }
                if (yRot > 30f)
                {
                    yRot = 30f;
                }

                transform.rotation = Quaternion.Euler(yRot, xRot, 0f);

                line.gameObject.SetActive(true);
                line.SetPosition(0, transform.position);
                line.SetPosition(1, transform.position + transform.forward * 4f);

                holdTime += Time.deltaTime;
                shootPower = Mathf.Clamp(holdTime * 10f, 30f, 300f);
            }

            if (Input.GetMouseButtonUp(0))
            {


                FindObjectOfType<AudioManager>().Play("BallHit");
                rb.velocity = transform.forward * shootPower;
                numCollisions = 0;
                line.gameObject.SetActive(false);
                holdTime = 0f;
            }


            if (Input.GetMouseButton(1))
            {
                xRot += Input.GetAxis("Mouse X") * rotationSpeed;
                yRot -= Input.GetAxis("Mouse Y") * rotationSpeed;

                if (yRot < -14f)
                {
                    yRot = -14f;
                }
                if (yRot > 30f)
                {
                    yRot = 30f;
                }


                transform.rotation = Quaternion.Euler(yRot, xRot, 0f);

            }
        }
        timeSinceDecrease += Time.deltaTime;
        //decreasing the velocity and angular velocity of the ball
        if (timeSinceDecrease > decreaseInterval)
        {
            rb.velocity -= rb.velocity.normalized * velocityDecrease;
            rb.angularVelocity -= rb.angularVelocity.normalized * angularVelocityDecrease;
            timeSinceDecrease = 0f;
        }

    }
    //this will slower the ball to make it stop
    private void OnCollisionEnter(Collision collision)
    {
        //FindObjectOfType<AudioManager>().Play("HitWall");

        numCollisions++;

        if (numCollisions >= 3)
        {
            rb.velocity -= rb.velocity.normalized * velocityDecrease;
            rb.angularVelocity -= rb.angularVelocity.normalized * angularVelocityDecrease;
            numCollisions = 0;
        }

        
    }


}
