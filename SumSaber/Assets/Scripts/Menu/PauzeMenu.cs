using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauzeMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    [SerializeField] GameObject pauzeMenuUI;

    [SerializeField] Canvas SumCanvas;
    [SerializeField] GameObject Cubes;

    [SerializeField] GameObject saber_righthand;
    [SerializeField] GameObject saber_lefthand;
    [SerializeField] GameObject controller_righthand;
    [SerializeField] GameObject controller_lefthand;

    private void Start()
    {
        pauzeMenuUI.SetActive(false);
    }

    public void PauseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed && Numbers.GameIsEnd == false)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pauze();
            }
        }
    }

    public void Resume()
    {
        pauzeMenuUI.SetActive(false);
        SumCanvas.enabled = true;
        Cubes.SetActive(true);

        if (GameModeController.settings.sabermode == 0)
        {
            saber_righthand.SetActive(true);
            saber_lefthand.SetActive(true);
        }
        else if (GameModeController.settings.sabermode == 1)
        {
            saber_righthand.SetActive(true);
            saber_lefthand.SetActive(false);
        }

        controller_righthand.SetActive(false);
        controller_lefthand.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pauze()
    {
        pauzeMenuUI.SetActive(true);
        SumCanvas.enabled = false;
        Cubes.SetActive(false);

        saber_righthand.SetActive(false);
        saber_lefthand.SetActive(false);

        if (GameModeController.settings.sabermode == 0)
        {
            controller_righthand.SetActive(true);
            controller_lefthand.SetActive(true);
        }
        else if (GameModeController.settings.sabermode == 1)
        {
            controller_righthand.SetActive(true);
            controller_lefthand.SetActive(false);
        }

        Time.timeScale = 0f;
        GameIsPaused = true;
    }


}
