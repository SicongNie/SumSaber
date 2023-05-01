using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModesSetting : MonoBehaviour
{
    [SerializeField] private Canvas optiecanvas;
    [SerializeField] private Canvas menucanvas;

    [SerializeField] private GameObject keeropties;
    [SerializeField] private GameObject plusopties;
    [SerializeField] private GameObject deelusopties;
    [SerializeField] private GameObject minopties;



    public void GameCanvas_keer()
    {
        GameModeController.SelectedOperator = GameModeController.MathOperator.keer;
        optiecanvas.gameObject.SetActive(true);
        menucanvas.gameObject.SetActive(false);
        keeropties.SetActive(true);
        plusopties.SetActive(false);
        deelusopties.SetActive(false);
        minopties.SetActive(false);

    }

    public void GameCanvas_plus()
    {
        GameModeController.SelectedOperator = GameModeController.MathOperator.plus;
        optiecanvas.gameObject.SetActive(true);
        menucanvas.gameObject.SetActive(false);
        keeropties.SetActive(false);
        plusopties.SetActive(true);
        deelusopties.SetActive(false);
        minopties.SetActive(false);

    }
    public void GameCanvas_min()
    {
        GameModeController.SelectedOperator = GameModeController.MathOperator.min;
        optiecanvas.gameObject.SetActive(true);
        menucanvas.gameObject.SetActive(false);
        keeropties.SetActive(false);
        plusopties.SetActive(false);
        deelusopties.SetActive(false);
        minopties.SetActive(true);

    }

    public void GameCanvas_deel()
    {
        GameModeController.SelectedOperator = GameModeController.MathOperator.deel;
        optiecanvas.gameObject.SetActive(true);
        menucanvas.gameObject.SetActive(false);
        keeropties.SetActive(false);
        plusopties.SetActive(false);
        deelusopties.SetActive(true);
        minopties.SetActive(false);

    }

    public void BacktoModeMenu()
    {
        optiecanvas.gameObject.SetActive(false);
        menucanvas.gameObject.SetActive(true);
    }
}
