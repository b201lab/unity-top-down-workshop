using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool gameIsPaused = false;
    public GameObject gameOverMenuUI;

    public void GameOver()
    {
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void RetryGame()
    {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        SceneManager.LoadScene("Game");
    }

    public void MenuGame()
    {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.End))
        {
            GameOver();
        }
    }
}
