using CarouselUI;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This script is responsible for managing the end of the game and controlling the visibility of the result menu
public class EndHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;  // UI\Result Canvas
    [SerializeField] Canvas sumcanvas;       // UI\Sum Canvas

    //the sbaers in the game scene
    [SerializeField] GameObject leftcontroller;     // Player\XR Orign\Camera Offset\LeftHand Controller
    [SerializeField] GameObject rightcontroller;    // Player\XR Orign\Camera Offset\RightHand Controller

    //the controllers for the UI
    [SerializeField] GameObject leftcontroller_menu;    //Player\XR Orign\Camera Offset\LeftHand Controller_Menu
    [SerializeField] GameObject rightcontroller_menu;   // Player\XR Orign\Camera Offset\RightHand Controller_Menu

    //Result menu
    [SerializeField] DynamicScrollView dynamicScrollView; //UI


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
