using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject game_over;

    private void Start()
    {
        Time.timeScale = 1;

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
        // Виходить з гри
        Application.Quit();

#if UNITY_EDITOR
        // Цей блок коду для відлагодження в редакторі Unity - при збірці ігноруватиметься
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
