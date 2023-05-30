using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void LoadHomeScene()
    {
        SceneManager.LoadScene(0);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

    public void LoadModeMenuScene()
    {
        SceneManager.LoadScene(2);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

    public void LoadModeMenuScene2()
    {
        SceneManager.LoadScene(2);
        SumGenerator.wrongAnswers.Clear();
        audioManager.PlayMusic(audioManager.menu);
        Time.timeScale = 1;
    }

    public void LoadSettingMenuScene()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
