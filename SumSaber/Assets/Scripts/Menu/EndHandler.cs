using CarouselUI;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas sumcanvas;

    [SerializeField] GameObject leftcontroller;
    [SerializeField] GameObject rightcontroller;

    [SerializeField] GameObject leftcontroller1;
    [SerializeField] GameObject rightcontroller1;


    [SerializeField] DynamicScrollView dynamicScrollView;

    /*    [SerializeField] TextMeshProUGUI sumsTxt;
        [SerializeField] GameObject scrollViewContent;
        [SerializeField] GameObject listItemPrefab;*/

    private void Start()
    {
        gameOverCanvas.enabled = false;

        leftcontroller1.SetActive(false);
        rightcontroller1.SetActive(false);
    }
    public void HandleEnd()
    {
        sumcanvas.enabled = false;
        gameOverCanvas.enabled = true;

        leftcontroller.SetActive(false);
        rightcontroller.SetActive(false);

        leftcontroller1.SetActive(true);
        rightcontroller1.SetActive(true);

        dynamicScrollView.ShowResult();

        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
