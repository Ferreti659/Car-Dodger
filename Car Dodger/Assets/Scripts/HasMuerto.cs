using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class HasMuerto : MonoBehaviour
{
    
    public LeaderBoard leaderBoard;
    public BaseDatos baseDatos;
    public GameObject gameOverScreen;
    public GameObject pauseBtn;
    public Text secondsSurvivedUI;
    bool gameOver;

    public TMP_InputField MemberID;
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
                Debug.Log("Failed1" + response.Error);
            }
        });
    }




    void Update()
    {

        if (gameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {

                DieRoutine();
                SceneManager.LoadScene(1);

            }
        }   
    }

    void OnGameOver()
    {
        int tiempo = Mathf.RoundToInt(Time.timeSinceLevelLoad);
        pauseBtn.SetActive(false);
        gameOverScreen.SetActive(true);
        secondsSurvivedUI.text = tiempo.ToString();
        Debug.Log(MemberID.text);
        baseDatos.añadirPlayer(MemberID.text, tiempo);
        gameOver = true;
    }

    IEnumerator DieRoutine()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1f);
        yield return leaderBoard.SubmitScoreRoutine(Time.timeSinceLevelLoad);
        Time.timeScale = 1f;
        
    }

}
