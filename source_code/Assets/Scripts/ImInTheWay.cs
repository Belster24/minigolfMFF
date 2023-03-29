using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImInTheWay : MonoBehaviour
{
    [SerializeField] private GameObject solidObject;
    [SerializeField] private GameObject transparentObject;


    private void Awake()
    {
        ShowSolid();
    }


    public void ShowTransparent()
    {
        solidObject.SetActive(false);
        transparentObject.SetActive(true);
    }

    public void ShowSolid()
    {
        solidObject.SetActive(true);
        transparentObject.SetActive(false);
    }

}
