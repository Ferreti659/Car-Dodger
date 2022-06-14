using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject pauseMenu;
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject jugarMenu;
    public GameObject rankingMenu;
    public BaseDatos baseDatos;
    public Text rankingText;





    public bool pause;

    private void Awake()
    {
         baseDatos.CrearTabla();
        Debug.Log("intento");
    }
    void Start()
    {
        
        Time.timeScale = 0;
       
        pauseBtn.SetActive(false);
        mainMenu.SetActive(true);
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        
        jugarMenu.SetActive(true);

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
        pauseBtn.SetActive(false);
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);

    }

    public void optionsMainButton()
    {

        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);

    }

    public void jugarButton()
    {
        SceneManager.LoadScene(1);
        Start();

    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
        Start();
    }

    public void rankingButton()
    {
        rankingMenu.SetActive(true);
        mainMenu.SetActive(false);

    }

    public void cargarButton()
    {
        jugarMenu.SetActive(false);
        Time.timeScale = 1;
        pauseBtn.SetActive(true);

    }

    public void atrasButton()
    {
        pauseMenu.SetActive(true);
        optionsMenu.SetActive(false);

    }

    public void atrasJugarButton()
    {
        mainMenu.SetActive(true);

        jugarMenu.SetActive(false);

    }

    public void atrasOpcionesButton()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    public void atrasRankingButton()
    {
        mainMenu.SetActive(true);
        rankingMenu.SetActive(false);
    }

}




