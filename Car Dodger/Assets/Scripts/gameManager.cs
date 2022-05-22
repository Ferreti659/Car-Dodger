using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject pauseMenu;

    public bool pause;

    void Start()
    {
        pauseMenu.SetActive(false);
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
       

    }


}




