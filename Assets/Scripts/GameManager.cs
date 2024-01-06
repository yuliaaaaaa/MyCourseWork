using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject game_over;

    void Start()
    {
        Time.timeScale = 1;
    }
    public void StartGame()
    {
        // Завантаження поточної сцени
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(1);

    }

    public void GameOver()
    {
        game_over.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenRecords()
    {
        SceneManager.LoadScene(2);
    }
}
