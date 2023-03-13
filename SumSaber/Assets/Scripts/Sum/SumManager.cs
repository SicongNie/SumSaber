using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SumManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI question;

    private int num1;
    private int num2;
    private char op;
    private char[] ops = { '+', '-', '*' };


    private int[] answerOptions = new int[4];
    [SerializeField] List<TextMeshPro> answerTexts;
    private int correctAnswerIndex;

    List<string> correctAnswers = new List<string>();
    List<string> wrongAnswers = new List<string>();


    void Start()
    {
        GenerateProblem();
    }

    public void GenerateProblem()
    {
        num1 = Random.Range(1, 10);
        num2 = Random.Range(1, 10);

        int randomIndex = Random.Range(0, ops.Length);
        op = ops[randomIndex];

        string problemText = string.Format("{0} {1} {2} = ?", num1, op, num2);
        question.text = problemText;

        GenerateAnswer();
    }

    void GenerateAnswer()
    {
        int correctAnswer = 0;

        switch (op)
        {
            case '+':
                correctAnswer = num1 + num2;
                break;
            case '-':
                correctAnswer = num1 - num2;
                break;
            case '*':
                correctAnswer = num1 * num2;
                break;
        }

        for (int i = 0; i < answerOptions.Length; i++)
        {
            if (i == correctAnswerIndex)
            {
                answerOptions[i] = correctAnswer;
            }
            else
            {
                answerOptions[i] = Random.Range(1, 20);
            }
        }

        Shuffle(answerOptions);


        for (int i = 0; i < answerTexts.Count; i++)
        {
            answerTexts[i].SetText(answerOptions[i].ToString());
        }
    }

    private void Shuffle(int[] answers)
    {
        for (int i = 0; i < answers.Length; i++)
        {
            int temp = answers[i];
            int randomIndex = Random.Range(i, answers.Length);
            answers[i] = answers[randomIndex];
            answers[randomIndex] = temp;
        }
    }

    public bool CheckAnswer(int a)
    {
        int correctAnswer = 0;
        switch (op)
        {
            case '+':
                correctAnswer = num1 + num2;
                break;
            case '-':
                correctAnswer = num1 - num2;
                break;
            case '*':
                correctAnswer = num1 * num2;
                break;
        }

        if (a == correctAnswer)
        {
            correctAnswers.Add(question.text);
            return true;
        }
        else
        {
            wrongAnswers.Add(question.text);
            return false;
        }
    }



}
