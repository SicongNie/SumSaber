using CarouselUI;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This script is responsible for managing the end of the game and controlling the visibility of the result menu
public class EndHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas sumcanvas;

    //the sbaers in the game scene
    [SerializeField] GameObject leftcontroller;
    [SerializeField] GameObject rightcontroller;

    //the controllers for the UI
    [SerializeField] GameObject leftcontroller_menu;
    [SerializeField] GameObject rightcontroller_menu;

    //Result menu
    [SerializeField] DynamicScrollView dynamicScrollView;


    private void Start()
    {
        gameOverCanvas.enabled = false;

        leftcontroller_menu.SetActive(false);
        rightcontroller_menu.SetActive(false);
    }

    //if numbers of sums is 0, the game is over
    public void HandleEnd()
    {
        sumcanvas.enabled = false;
        gameOverCanvas.enabled = true;

        leftcontroller.SetActive(false);
        rightcontroller.SetActive(false);

        leftcontroller_menu.SetActive(true);
        rightcontroller_menu.SetActive(true);

        dynamicScrollView.ShowResult();

        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
