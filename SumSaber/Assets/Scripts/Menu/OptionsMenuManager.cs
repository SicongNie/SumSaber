using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenuManager : MonoBehaviour
{
    [SerializeField] private Canvas optionscanvas;
    [SerializeField] private Canvas modescanvas;

    [SerializeField] private GameObject option_keer;
    [SerializeField] private GameObject option_plus;
    [SerializeField] private GameObject option_deel;
    [SerializeField] private GameObject option_min;

    public void GameCanvas_keer()
    {
        GameModeController.SelectedOperator = GameModeController.MathOperator.keer;
        optionscanvas.gameObject.SetActive(true);
        modescanvas.gameObject.SetActive(false);
        option_keer.SetActive(true);
        option_plus.SetActive(false);
        option_deel.SetActive(false);
        option_min.SetActive(false);
    }

    public void GameCanvas_plus()
    {
        GameModeController.SelectedOperator = GameModeController.MathOperator.plus;
        optionscanvas.gameObject.SetActive(true);
        modescanvas.gameObject.SetActive(false);
        option_keer.SetActive(false);
        option_plus.SetActive(true);
        option_deel.SetActive(false);
        option_min.SetActive(false);
    }
    public void GameCanvas_min()
    {
        GameModeController.SelectedOperator = GameModeController.MathOperator.min;
        optionscanvas.gameObject.SetActive(true);
        modescanvas.gameObject.SetActive(false);
        option_keer.SetActive(false);
        option_plus.SetActive(false);
        option_deel.SetActive(false);
        option_min.SetActive(true);
    }

    public void GameCanvas_deel()
    {
        GameModeController.SelectedOperator = GameModeController.MathOperator.deel;
        optionscanvas.gameObject.SetActive(true);
        modescanvas.gameObject.SetActive(false);
        option_keer.SetActive(false);
        option_plus.SetActive(false);
        option_deel.SetActive(true);
        option_min.SetActive(false);
    }

    public void BacktoModeMenu()
    {
        optionscanvas.gameObject.SetActive(false);
        modescanvas.gameObject.SetActive(true);
    }
}
