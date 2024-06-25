using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public TMP_InputField nameField;
    public TMP_InputField passwordField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/register.php", form))
        {

            yield return www.SendWebRequest();
            if (www.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Server response: " + www.downloadHandler.text); // Вивести всю відповідь сервера
                if (www.downloadHandler.text == "0") 
                {
                    Debug.Log("User created successfully!");
                    UnityEngine.SceneManagement.SceneManager.LoadScene(0);
                }
                else
                {
                    Debug.Log("User creation failed. Unexpected server response. ");
                }
            }
            else
            {
                Debug.Log("User creation failed. Error#" + www.responseCode);

            }
        }
    }


    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }
}