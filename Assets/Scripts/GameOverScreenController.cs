using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreenController : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] GameObject GameOverMenu;

    public void TryAgain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);

    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
