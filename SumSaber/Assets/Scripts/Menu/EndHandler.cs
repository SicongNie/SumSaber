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

    [SerializeField] TextMeshProUGUI sumsTxt;
    [SerializeField] GameObject scrollViewContent;
    [SerializeField] GameObject listItemPrefab;

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

        foreach (Transform child in scrollViewContent.transform)
        {
            Destroy(child.gameObject);
        }

        List<string> wrongAnswers = SumGenerator.wrongAnswers;
        if (wrongAnswers.Count > 0)
        {
            foreach (string answer in wrongAnswers)
            {
                //  wrongAnswersText += answer + "\n";
                GameObject listItem = Instantiate(listItemPrefab, scrollViewContent.transform);
                TextMeshProUGUI listItemText = listItem.GetComponentInChildren<TextMeshProUGUI>();
                listItemText.text = answer;
                listItemText.enabled = true;

            }
        }
        else
        {
            if (CarouselUIElement._currentIndex == 0)
            {
                sumsTxt.text = "Je hebt alle sommen goed gemaakt!";
            }
            else if (CarouselUIElement._currentIndex == 1)
            {
                sumsTxt.text = "You did all the sums right!";
            }
        }

        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
