using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTransparent : MonoBehaviour
{

    [SerializeField]private List<ImInTheWay> currentlyInTheWay;
    [SerializeField] private List<ImInTheWay> alreadyTransparent;
    [SerializeField] private Transform Ball;
    private Transform Camera;

    private void Awake()
    {
        currentlyInTheWay = new List<ImInTheWay>();
        alreadyTransparent = new List<ImInTheWay>();
    }
    
    private void Start()
    {

        Camera = GameObject.Find("MainCamera").transform;

        //Camera = UnityEngine.Camera.current.transform;
    }


    private void Update()
    {
       

        GetAllObjectsInTheWay();

        MakeObjectsSolid();
        MakeObjectsTransparent();

        

    }

    private void GetAllObjectsInTheWay()
    {
        currentlyInTheWay.Clear();

       

        float cameraPlayerDistance = Vector3.Magnitude(Camera.position - Ball.position);

        //Debug.Log(cameraPlayerDistance);

        Ray ray1_Forward = new Ray(Camera.position, Ball.position - Camera.position);
        Ray ray1_Backward = new Ray(Ball.position, Camera.position - Ball.position);
        
        var hits1_Forward = Physics.RaycastAll(ray1_Forward, cameraPlayerDistance);
        var hits1_Backward = Physics.RaycastAll(ray1_Backward, cameraPlayerDistance);

        

        foreach (var hit in hits1_Forward)
        {
            if (hit.collider.gameObject.TryGetComponent(out ImInTheWay imInTheWay))
            {
                if (!currentlyInTheWay.Contains(imInTheWay))
                {
                    currentlyInTheWay.Add(imInTheWay);
                    
                }
            }
        }

        foreach (var hit in hits1_Backward)
        {
            if (hit.collider.gameObject.TryGetComponent(out ImInTheWay imInTheWay))
            {
                if (!currentlyInTheWay.Contains(imInTheWay))
                {
                    currentlyInTheWay.Add(imInTheWay);
                    
                }
            }
        }


    }

    private void MakeObjectsTransparent()
    {

        for (int i = 0; i < currentlyInTheWay.Count; i++)
        {
            ImInTheWay iamInTheWay = currentlyInTheWay[i];
            
            if (alreadyTransparent.Contains(iamInTheWay)) {
                iamInTheWay.ShowTransparent();
                alreadyTransparent.Add(iamInTheWay);
            }
        }


    }

    private void MakeObjectsSolid()
    {
        for (int i = alreadyTransparent.Count-1; i >= 0; i--)
        {
            ImInTheWay wasInWay = alreadyTransparent[i];
            if (!currentlyInTheWay.Contains(wasInWay))
            {
                wasInWay.ShowSolid();
                alreadyTransparent.Remove(wasInWay);
            }
        }


    }
}
