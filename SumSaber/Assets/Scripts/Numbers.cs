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


    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        maxQuestionCount = GameModeController.settings.numQuestions;
        Debug.Log(maxQuestionCount);
    }

    void Update()
    {
        counterText.text = (maxQuestionCount - questionCount).ToString();
    }

    public void EndGame()
    {
        GetComponent<EndHandler>().HandleEnd();
    }

}
