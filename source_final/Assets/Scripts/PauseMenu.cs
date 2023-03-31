using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
  
    public Button button;
    public float speedOfFly = 5f;

    private bool fly = false;
    private int clickCount = 0;


    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        GameObject player = GameObject.FindWithTag("Player");
        Rigidbody rb = player.GetComponent<Rigidbody>();

        if (fly)
        {


            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            float fly = Input.GetAxis("Jump");

            player.transform.Translate(new Vector3(horizontal, fly, vertical) * speedOfFly * Time.deltaTime);

            rb.useGravity = false;
        }else if (!fly)
        {
            rb.useGravity= true;
        }

    }
     
    public void Resume()
    {
        GameObject.Find("ScoreText").GetComponent<Score>().enabled = true;
        GameObject.FindWithTag("CameraControler").GetComponent<Controler>().enabled = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        
    }

    public void Pause()
    {
        GameObject.Find("ScoreText").GetComponent<Score>().enabled = false;
        GameObject.FindWithTag("CameraControler").GetComponent<Controler>().enabled = false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;



    }
    
    public void Save()
    {
        Debug.Log("Saved");
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(0);
    }


    // Cheats here

    public void SkipLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Fly()
    {
        clickCount++;
        Debug.Log(clickCount + " Clicknuto");
        if(clickCount == 1)
        {
            fly = true;
        }else if(clickCount == 2)
        {
            fly = false;
        }
        else
        {
            fly = true;
            clickCount = 1;
        }

    }
}
