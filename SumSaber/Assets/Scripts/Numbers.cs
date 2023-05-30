using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static GameModeController;

public class Numbers : MonoBehaviour
{
    public int questionCount = 0;
    public int maxQuestionCount;


    TextMeshProUGUI counterText;

    public bool canTrigger = true;
    public static bool GameIsEnd;

    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        maxQuestionCount = GameModeController.settings.numQuestions;
    }

    void Update()
    {
        counterText.text = (maxQuestionCount - questionCount).ToString();
        if (questionCount >= maxQuestionCount)
        {
            GameIsEnd = true;
        }
        else
        {
            GameIsEnd = false;
        }
    }

    public void EndGame()
    {
        GetComponent<EndHandler>().HandleEnd();
    }

}
