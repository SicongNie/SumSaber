using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Numbers : MonoBehaviour
{
    public int questionCount = 0;
    public int maxQuestionCount = 2;


    TextMeshProUGUI counterText;


    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
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
