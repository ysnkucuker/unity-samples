using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseUI;
    public void OnRestartPress()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnGameResumePress()
    {
        Time.timeScale = 1.0f;
        pauseUI.SetActive(false);
    }

    public void OnGameExit()
    {
          Application.Quit();
    }

    public void OnEnterPausePressed()
    {
        Time.timeScale = 0f;  
        pauseUI.SetActive(true);
    }
}
