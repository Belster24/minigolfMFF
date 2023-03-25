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


    private UIDocument root;
    // Start is called before the first frame update
    void Awake()
    {
        root = GetComponent<UIDocument>();



       
        yesButton = root.rootVisualElement.Q<Button>("ano-button");
        noButton = root.rootVisualElement.Q<Button>("ne-button");


        noButton.clicked += NoButtonClicked;
        yesButton.clicked += YesButtonClicked;



    }

    private void OnEnable()
    {

        root = GetComponent<UIDocument>();

        yesButton = root.rootVisualElement.Q<Button>("ano-button");
        noButton = root.rootVisualElement.Q<Button>("ne-button");

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
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
