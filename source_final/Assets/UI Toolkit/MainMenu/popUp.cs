using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;


public class popUp : MonoBehaviour
{
    
    public GameObject popup;
    public GameObject start;
    public Button yesButton;
    public Button noButton;


    //private UIDocument root;
    // Start is called before the first frame update
    void Start()
    {
        //root = GetComponent<UIDocument>();

       


       
        yesButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("ano-button");
        noButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("ne-button");


        noButton.clicked += NoButtonClicked;
        yesButton.clicked += YesButtonClicked;



    }

    private void OnEnable()
    {

        //root = GetComponent<UIDocument>();

        yesButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("ano-button");
        noButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("ne-button");

        noButton.clicked += NoButtonClicked;
        yesButton.clicked += YesButtonClicked;


    }

    void NoButtonClicked()
    {
        popup.SetActive(false);
        start.SetActive(true);
    }
    
    void YesButtonClicked()
    {
        
       PlayerPrefs.DeleteAll();

        PlayerPrefs.SetString("Score1", "0");
        PlayerPrefs.SetString("Score2", "0");
        PlayerPrefs.SetString("Score3", "0");
        PlayerPrefs.SetString("Score4", "0");
        PlayerPrefs.SetString("Score5", "0");
   
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
