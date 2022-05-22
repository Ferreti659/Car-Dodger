using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject pauseMenu;
    public bool pause;


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

    void update()
    {

            if (Input.GetKeyDown(KeyCode.Space))
            {
            if (pause)
            {
                pauseButton();
            }
            else
            {
                playButton();
            }
            }
    }
}




