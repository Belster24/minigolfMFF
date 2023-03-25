using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;




public class menuScript : MonoBehaviour
{

    public GameObject option;
    public GameObject start;
    public GameObject popup;
    
    public Button startButton;
    public Button optionButton;
    public Button loadButton;
    public Button yesButton;
    public Button noButton;
    public Button quitButton;

    private UIDocument root;
    // Start is called before the first frame update
    private void Awake()
    {
        root = GetComponent<UIDocument>();

        startButton = root.rootVisualElement.Q<Button>("start-button");
        optionButton = root.rootVisualElement.Q<Button>("options-button");
        loadButton = root.rootVisualElement.Q<Button>("load-button");
        yesButton = root.rootVisualElement.Q<Button>("ano-button");
        noButton = root.rootVisualElement.Q<Button>("ne-button");
        quitButton = root.rootVisualElement.Q<Button>("quit-button");

        startButton.clicked += StartButtonClicked;

        optionButton.clicked += OptionClicked;

        loadButton.clicked += LoadClicked;

        quitButton.clicked += QuitClicked;
    }


    private void OnEnable()
    {
        root = GetComponent<UIDocument>();

        startButton = root.rootVisualElement.Q<Button>("start-button");
        optionButton = root.rootVisualElement.Q<Button>("options-button");
        loadButton = root.rootVisualElement.Q<Button>("load-button");
        yesButton = root.rootVisualElement.Q<Button>("ano-button");
        noButton = root.rootVisualElement.Q<Button>("ne-button");

        startButton.clicked += StartButtonClicked;

        optionButton.clicked += OptionClicked;

        loadButton.clicked += LoadClicked;

        

    }

    void StartButtonClicked()
    {
        start.SetActive(false);
        popup.SetActive(true);
      
    }


    void OptionClicked()
    {

        option.SetActive(true);
        start.SetActive(false);


    }

    void LoadClicked()
    {

        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));

    }

    void QuitClicked()
    {
        Application.Quit();
    }
}
