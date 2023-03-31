using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    public GameObject cheat;

    void Start()
    {

        if (Application.platform == RuntimePlatform.Android)
        {

            cheat.SetActive(false);

        }

    }


}
