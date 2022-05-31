using UnityEngine.UI;
using LootLocker.Requests;
using UnityEngine;

public class LeaderBoardController : MonoBehaviour
{

    public InputField MemberID, PlayerScore;
    public int ID;

    private void Start()
    {
        LootLockerSDKManager.StartSession("Player", (response) =>
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
    }


    public void SubmitScore()
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
    }

}
