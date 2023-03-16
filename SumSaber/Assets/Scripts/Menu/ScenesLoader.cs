using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesLoader : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
