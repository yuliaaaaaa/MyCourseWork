using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject game_over;

    public TMP_Text playerDisplay;


    private void Start()
    {
        Time.timeScale = 1;

        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player" + DBManager.username;

        }
    }
    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }

    public void GameOver()
    {
        game_over.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenRecords()
    {
        SceneManager.LoadScene(2);
    }

    public void Online()
    {
        SceneManager.LoadScene(3);
    }

    public void Register()
    {
        SceneManager.LoadScene(4);
    }

    public void LogIn()
    {
        SceneManager.LoadScene(5);
    }

    public void ExitGameButtonClicked()
    {
        // �������� � ���
        Application.Quit();

#if UNITY_EDITOR
        // ��� ���� ���� ��� ������������ � �������� Unity - ��� ����� ����������������
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
