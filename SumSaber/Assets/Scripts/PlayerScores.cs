using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    public int score = 0;

    TextMeshProUGUI scoreText;

    public void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        scoreText.text = score.ToString();
    }

    public void GetScores(bool a)
    {
        if (a)
        {
            score += 10;
        }
        else
        {
            score -= 10;
        }
    }

}
