using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

    public void LoadModeMenuScene()
    {
        SceneManager.LoadScene(2);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

    public void LoadOptionMenuScene()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
