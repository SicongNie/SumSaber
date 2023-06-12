using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    public float score = 10.0f;

    TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI scoreTxt_Result;

    public void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        if (score < 0)
        {
            score = 0;
        }
        scoreText.text = score.ToString("F1");
        scoreTxt_Result.text = score.ToString("F1");
    }

    public void GetScores(bool a)
    {
        if (a)
        {
            return;
        }
        else
        {
            if (GameModeController.settings.numQuestions == 10)
            {
                score -= 1.0f;
            }
            else if (GameModeController.settings.numQuestions == 30)
            {
                score -= 0.3f;
            }
            else if (GameModeController.settings.numQuestions == 50)
            {
                score -= 0.2f;
            }

        }
    }

}
