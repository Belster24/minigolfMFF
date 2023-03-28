using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.Audio;


public class settingMenu : MonoBehaviour
{

    public GameObject option;
    public GameObject start;
    public Button backButton;
    public Button hdres;
    public Button fhdres;

    public Foldout foldout;
    public Toggle fullwin;
    public Slider vol;


    public UIDocument root;
    // Start is called before the first frame update

    

    void Start()
    {
        //root = GetComponent<UIDocument>();

        vol = GetComponent<UIDocument>().rootVisualElement.Q<Slider>("volume-slider");

        backButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("back-button");
        fullwin = GetComponent<UIDocument>().rootVisualElement.Q<Toggle>("fullscreen");
        hdres = GetComponent<UIDocument>().rootVisualElement.Q<Button>("hd-res");
        fhdres = GetComponent<UIDocument>().rootVisualElement.Q<Button>("fhd-res");


      

        backButton.clicked += BackButtonClicked;

        vol.value = AudioListener.volume;
       


    }

    private void OnEnable()
    {

        root = GetComponent<UIDocument>();

        backButton = root.rootVisualElement.Q<Button>("back-button");
        fullwin = GetComponent<UIDocument>().rootVisualElement.Q<Toggle>("fullscreen");
        hdres = GetComponent<UIDocument>().rootVisualElement.Q<Button>("hd-res");
        fhdres = GetComponent<UIDocument>().rootVisualElement.Q<Button>("fhd-res");
        vol = GetComponent<UIDocument>().rootVisualElement.Q<Slider>("volume-slider");

        vol.value = AudioListener.volume;
        backButton.clicked += BackButtonClicked;

        

    }
     void Update()
    {
        Windowed();

        hdres.clicked += HDButtonClick;

        fhdres.clicked += FHDButtonClick;

        AudioListener.volume = vol.value;
    }

    void BackButtonClicked()
    {
        option.SetActive(false);
        start.SetActive(true);
    }

    void HDButtonClick()
    {
        Screen.SetResolution(1280, 720, fullwin.value);
    }

    void FHDButtonClick()
    {

        Screen.SetResolution(1920, 1080, fullwin.value);

    }

     void Windowed()
    {
        if (fullwin.value == true)
        {
            
            Screen.fullScreen = true;

        }
        else
        {

           Screen.fullScreen= false;

        }
        

    }


}
