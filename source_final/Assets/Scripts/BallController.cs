using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float maxForce = 20.0f;
    public float chargeTime = 2.0f;
    
    private Rigidbody rb;
    private float currentForce = 0.0f;
    private bool isCharging = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Start charging the ball when the player holds down the left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            isCharging = true;
            currentForce = 0.0f;
        }

        // Increase the force of the ball while the player holds down the left mouse button
        if (Input.GetMouseButton(0) && isCharging)
        {
            currentForce += maxForce * Time.deltaTime / chargeTime;
            currentForce = Mathf.Clamp(currentForce, 0.0f, maxForce);
        }

        // Shoot the ball when the player releases the left mouse button
        if (Input.GetMouseButtonUp(0) && isCharging)
        {
            rb.AddForce(transform.forward * currentForce, ForceMode.Impulse);
            isCharging = false;
        }
    }
}
