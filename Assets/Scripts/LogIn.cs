using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LogIn : MonoBehaviour
{
    public TMP_InputField nameField;
    public TMP_InputField passwordField;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(Login());
    }

    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);

        UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlconnect/login.php", form);
        yield return www.SendWebRequest();
        Debug.Log(www.downloadHandler.text);

        if (www.downloadHandler.text[0] == '0')
        {
            DBManager.username = nameField.text;
            DBManager.score = int.Parse(www.downloadHandler.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);

        }
        else
        {
            Debug.Log("User login failed. Error #" + www.downloadHandler.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }
}
