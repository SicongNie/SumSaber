using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This script is used to keep track of the player's score
public class PlayerScores : MonoBehaviour
{   
    public float score = 10.0f;

    TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI scoreTxt_Result;    // UI\Results Menu\Panel\Score_Txt

    public void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        //score would not go below 0
        if (score < 0)
        {
            score = 0;
        }

        //Converts the score to a string with one decimal place
        scoreText.text = score.ToString("F1");
        scoreTxt_Result.text = score.ToString("F1");
    }

    //the score is reduced if the player gets a question wrong
    public void GetScores(bool a)
    {
        if (a)
        {
            return;
        }
        else
        {
            if (GameModeController.settings.numQuestions == 10) // if the number of questions is 10, the score is reduced by 1
            {
                score -= 1.0f;
            }
            else if (GameModeController.settings.numQuestions == 30)   // if the number of questions is 30, the score is reduced by 0.3
            {
                score -= 0.3f;
            }
            else if (GameModeController.settings.numQuestions == 50) // if the number of questions is 50, the score is reduced by 0.2
            {
                score -= 0.2f;
            }

        }
    }
}
