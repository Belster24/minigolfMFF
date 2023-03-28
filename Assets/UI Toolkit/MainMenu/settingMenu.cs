using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class settingMenu : MonoBehaviour
{

    public GameObject option;
    public GameObject start;
    public Button backButton;
    public Foldout foldout;
    public Toggle fullwin;


    private UIDocument root;
    // Start is called before the first frame update
    void Start()
    {
        //root = GetComponent<UIDocument>();

       

        backButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("back-button");
        fullwin = GetComponent<UIDocument>().rootVisualElement.Q<Toggle>("fullscreen");

        
        backButton.clicked += BackButtonClicked;

       
        

    }
    
    private void OnEnable()
    {

        root = GetComponent<UIDocument>();

        backButton = root.rootVisualElement.Q<Button>("back-button");


        backButton.clicked += BackButtonClicked;


    }

    void BackButtonClicked()
    {
        option.SetActive(false);
        start.SetActive(true);
    }

}
