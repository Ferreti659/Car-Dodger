using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject pauseMenu;
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject jugarMenu;


    public bool pause;

    void Start()
    {
        pauseBtn.SetActive(true);
        mainMenu.SetActive(true);
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        jugarMenu.SetActive(false);
    }

    void Update()
    {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pause)
                {
                    playButton();
                }
                else
                {
                    pauseButton();
                }
            }
    }

    public void pauseButton()
    {
        pauseBtn.SetActive(false);
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        pause = true;
    }


    public void playButton()
    {
        pauseBtn.SetActive(true);
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        pause = false;


    }

    public void optionsButton()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);

    }

    public void jugarButton()
    {
        jugarMenu.SetActive(true);
        mainMenu.SetActive(false);

    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
        Start();
    }

    public void cargarButton()
    {
        SceneManager.LoadScene(1);
    }

}




