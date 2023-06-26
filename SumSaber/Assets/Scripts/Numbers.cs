using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static GameModeController;

//This script is used to count the number of sums in the game scene.
public class Numbers : MonoBehaviour
{
    public int questionCount = 0; // the current number of sums in the game scene
    public int maxQuestionCount; // the max number of sums in the game scene


    TextMeshProUGUI counterText;

    public bool canTrigger = true;
    public static bool GameIsEnd;

    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        maxQuestionCount = GameModeController.settings.numQuestions; // the max number of sums in the game scene is set by the game option
    }

    void Update()
    {
        counterText.text = (maxQuestionCount - questionCount).ToString();
        //if the number of sums in the game scene is equal to the max number of sums, the game is over
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
