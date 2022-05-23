using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HasMuerto : MonoBehaviour
{

    public GameObject gameOverScreen;
    public GameObject pauseBtn;
    public Text secondsSurvivedUI;
    bool gameOver;


    void Start()
    {
        FindObjectOfType<personaje>().OnPlayerDeath += OnGameOver;
    }


    void Update()
    {

        if (gameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(1);
            }
        }   
    }

    void OnGameOver()
    {
        pauseBtn.SetActive(false);
        gameOverScreen.SetActive(true);
        secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
        gameOver = true;
    }


}
