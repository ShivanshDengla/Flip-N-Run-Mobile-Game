using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    
    public GameObject pauseButton;
    public GameObject ContinueButton;

    public int reward = 0;

    void Start()
    {
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
    }

    void Update()
    {
        if (reward > 0)
        {
            ContinueButton.SetActive(false);
        }

        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Continue()
    {
        reward = reward + 1;
        Time.timeScale = 1f;
    }
}
