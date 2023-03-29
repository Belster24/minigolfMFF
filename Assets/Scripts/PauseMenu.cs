using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
  
    public Button button;

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
}
