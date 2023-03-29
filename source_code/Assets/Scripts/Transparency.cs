using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparency : MonoBehaviour
{
    public GameObject objectToMakeTransparent;
    public GameObject player;
    public GameObject camera;

    void Update()
    {
        // Calculate the position of the object relative to the player and camera
        Vector3 objectPos = objectToMakeTransparent.transform.position;
        Vector3 playerPos = player.transform.position;
        Vector3 cameraPos = camera.transform.position;

        // Check if the object is between the player and camera
        if ((objectPos - playerPos).magnitude < (objectPos - cameraPos).magnitude)
        {
            // Make the object transparent
            Color newColor = objectToMakeTransparent.GetComponent<Renderer>().material.color;
            newColor.a = 0.5f;
            objectToMakeTransparent.GetComponent<Renderer>().material.color = newColor;
        }
        else
        {
            // Make the object opaque
            Color newColor = objectToMakeTransparent.GetComponent<Renderer>().material.color;
            newColor.a = 1f;
            objectToMakeTransparent.GetComponent<Renderer>().material.color = newColor;
        }
    }
}
