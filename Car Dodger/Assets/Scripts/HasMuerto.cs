using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HasMuerto : MonoBehaviour
{

    public GameObject gameOverScreen;
    public GameObject pauseBtn;
    public Text secondsSurvivedUI;
    bool gameOver;

    public InputField MemberID;
    public Text PlayerScore;
    public int ID;

    private void Start()
    {

        FindObjectOfType<personaje>().OnPlayerDeath += OnGameOver;

        LootLockerSDKManager.StartSession("Player", (response) =>
        {
            if (response.success)
            {
                Debug.Log("success");
            }
            else
            {
                Debug.Log("Failed1");
            }
        });
    }




    void Update()
    {

        if (gameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                LootLockerSDKManager.SubmitScore(MemberID.text, int.Parse(PlayerScore.text), ID, (response) =>
                {
                    if (response.success)
                    {
                        Debug.Log("success");
                    }
                    else
                    {
                        Debug.Log("Failed");
                    }
                });
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
