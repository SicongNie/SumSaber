using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CheckAnswers : MonoBehaviour
{

    private bool isTriggered;

    [SerializeField] private GameObject answer;

    [SerializeField] SumManager sumManager;
    [SerializeField] Scores scores;
    [SerializeField] Counter counter;

    private void Start()
    {

    }

    private void Update()
    {
        if (isTriggered)
        {
            if (Input.GetMouseButtonDown(0))
            {
                int a = int.Parse(answer.GetComponent<TextMeshPro>().text);


                if (counter.questionCount >= counter.maxQuestionCount)
                {
                    Debug.Log("GameOver");
                }
                else
                {
                    if (sumManager != null)
                    {
                        if (sumManager.CheckAnswer(a))
                        {
                            Debug.Log("correct");
                        }
                        else
                        {
                            Debug.Log("incorrect");
                        }
                        scores.GetScores(sumManager.CheckAnswer(a));
                        counter.questionCount++;
                        sumManager.GenerateProblem();

                    }
                    else
                    {
                        Debug.Log("myObject is null!");
                    }
                }
            }
        }
    }

    private void OnMouseEnter()
    {
        isTriggered = true;
    }

    private void OnMouseExit()
    {
        isTriggered = false;
    }

}
