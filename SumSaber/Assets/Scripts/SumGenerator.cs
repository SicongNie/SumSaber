using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SumGenerator : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI question;
    public List<TextMeshPro> answerTexts;

    [SerializeField] PlayerScores score;
    [SerializeField] Numbers counter;


    private int num1;
    private int num2;
    private char op;
    private char[] ops = { '+', '-', '*' };

    private int[] answerOptions = new int[4];
    private int correctAnswerIndex;


    private Coroutine timerCoroutine;
    private float timer = 10f;
    private bool isAnswered;

    //event
    public delegate void GenerateObjectDelegate(string generatedString);
    public static event GenerateObjectDelegate GenerateObjectEvent;

    private void Start()
    {
        timerCoroutine = StartCoroutine(QuestionTimer());
    }

    private void Update()
    {

    }

    IEnumerator QuestionTimer()
    {
        while (true)
        {
            GenerateQuestion();
            yield return new WaitForSeconds(timer);
            if (!isAnswered)
            {
                score.GetScores(false);
                counter.questionCount++;
                ShowCorrectAnswer();
                question.color = Color.red;
                yield return new WaitForSeconds(2.0f);

            }

        }
    }

    IEnumerator ShowQuestionDelayed()
    {
        ShowCorrectAnswer();
        yield return new WaitForSeconds(2.0f);
        isAnswered = false;
        timerCoroutine = StartCoroutine(QuestionTimer());
    }



    public void ShowQuesionAnswer()
    {
        StopCoroutine(timerCoroutine);
        timerCoroutine = StartCoroutine(ShowQuestionDelayed());

    }


    public void GenerateQuestion()
    {
        answerTexts.Clear();
        num1 = Random.Range(1, 10);
        num2 = Random.Range(1, 10);

        int randomIndex = Random.Range(0, ops.Length);
        op = ops[randomIndex];

        string problemText = string.Format("{0} {1} {2} = ?", num1, op, num2);

        question.color = Color.white;
        question.text = problemText;
        if (GenerateObjectEvent != null)
        {
            GenerateObjectEvent("generated string");
        }
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

    void Shuffle(int[] answers)
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
        isAnswered= true;
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
            question.color = Color.green;
            return true;
        }
        else
        {
            question.color = Color.red;
            return false;
        }
    }

    private void ShowCorrectAnswer()
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
        string problemText = string.Format("{0} {1} {2} = {3}", num1, op, num2, correctAnswer);
        question.text = problemText;
 
    }



}
