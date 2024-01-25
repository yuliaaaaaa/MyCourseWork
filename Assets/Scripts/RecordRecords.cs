using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class RecordRecords : MonoBehaviour
{
    public TMP_Text[] playerNames = new TMP_Text[3];
    public TMP_Text[] playerScores = new TMP_Text[3];

    public void CallRecords()
    {
        StartCoroutine(GetRecords());
    }

    IEnumerator GetRecords()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", DBManager.username);
        form.AddField("score", DBManager.score);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/records.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                string responseText = www.downloadHandler.text.Trim();

                // Split the string into an array of names and an array of scores
                string[] playerData = responseText.Split(',');

                // Check if the correct number of data elements is received
                if (playerData.Length == 6)
                {
                    // Assign names and scores to the corresponding arrays
                    for (int i = 0; i < 3; i++)
                    {
                        playerNames[i].text = playerData[i];
                        playerScores[i].text = playerData[i + 3];
                    }

                    // Log the received data
                    Debug.Log("Player 1: " + playerNames[0].text + ", Score: " + playerScores[0].text);
                    Debug.Log("Player 2: " + playerNames[1].text + ", Score: " + playerScores[1].text);
                    Debug.Log("Player 3: " + playerNames[2].text + ", Score: " + playerScores[2].text);
                }
                else
                {
                    Debug.LogError("Failed to parse server response. Incorrect data format.");
                }
            }
            else
            {
                Debug.LogError("Failed to get records. Error #" + www.responseCode + ": " + www.error);
            }
        }
    }
}
