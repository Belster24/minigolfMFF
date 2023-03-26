using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstruct : MonoBehaviour
{

    public Transform player;
    public MeshRenderer mesh;

    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraTransparent();
        
    }

    private void CameraTransparent()
    {
        Debug.DrawLine(transform.position, player.position, Color.green);

        if(Physics.Linecast(transform.position, player.position, out hit))
        {
            if (hit.collider.CompareTag("Obstruct"))
            {
                Debug.Log(hit.collider.name);
                mesh = hit.collider.GetComponent<MeshRenderer>();
                mesh.enabled = false;
            }
            else
            {
                mesh.enabled = true;
            }
            
        }
    }
}
