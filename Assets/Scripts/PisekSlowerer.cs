using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisekSlowerer : MonoBehaviour
{
    public float slowFactor = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.velocity *= slowFactor;
        }
    }
}
