using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script is used to load the different scenes
public class ScenesLoader : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Load the scnene Home
    public void LoadHomeScene()
    {
        SceneManager.LoadScene(0);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

    //Load the scene GamePlay
    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

    //Load the scene ModeMenu
    public void LoadModeMenuScene()
    {
        SceneManager.LoadScene(2);
        SumGenerator.wrongAnswers.Clear();
        Time.timeScale = 1;
    }

   //Load the scene ModeMenu with the backgrond music from the menu
    public void LoadModeMenuScene2()
    {
        SceneManager.LoadScene(2);
        SumGenerator.wrongAnswers.Clear();
        audioManager.PlayMusic(audioManager.menu);
        Time.timeScale = 1;
    }

    //Load the scene SettingMenu
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
