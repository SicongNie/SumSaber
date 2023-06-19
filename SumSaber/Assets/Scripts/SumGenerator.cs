using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static GameModeController;

public class SumGenerator : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI question;

    [SerializeField] PlayerScores score;
    [SerializeField] Numbers counter;
    [SerializeField] CubeSpawner cubeSpawner;

    private int num1;
    private int num2;
    private char op;
    //  private char[] ops = { '+', '-', '*' };

    public List<TextMeshPro> answerTexts;
    private int[] answerOptions;
   // private int correctAnswerIndex;

    private Coroutine timerCoroutine;
    private bool isAnswered;

    public bool canTrigger;

    //event
    public delegate void GenerateObjectDelegate(string generatedString);
    public static event GenerateObjectDelegate GenerateObjectEvent;

    public static List<string> wrongAnswers = new List<string>();

    AudioManager audioManager;

    private string previousProblem = "";

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void Start()
    {
        audioManager.PlayCountdown(audioManager.CountDown);
        timerCoroutine = StartCoroutine(StartGame());
        canTrigger = true;
    }

    public void GenerateQuestion()
    {
        answerTexts.Clear();

        num1 = Random.Range(1, 10);
        num2 = Random.Range(1, 10);
        // int randomIndex = Random.Range(0, ops.Length);
        // op = ops[randomIndex];
        switch (GameModeController.SelectedOperator)
        {
            case MathOperator.plus:
                op = '+';
                if ((int)SelectedPlus == 0)
                {
                    num1 = Random.Range(1, ((int)SelectedPlus + 1) * 10);
                    num2 = Random.Range(1, ((int)SelectedPlus + 1) * 10);
                }
                else
                {
                    num1 = Random.Range((int)SelectedPlus * 10, ((int)SelectedPlus + 1) * 10);
                    num2 = Random.Range((int)SelectedPlus * 10, ((int)SelectedPlus + 1) * 10);
                }
                break;
            case MathOperator.min:
                op = '-';
                if ((int)SelectedMin == 0)
                {
                    num1 = Random.Range(1, ((int)SelectedPlus + 1) * 10);
                    num2 = Random.Range(1, num1);
                }
                else
                {
                    num1 = Random.Range((int)SelectedPlus * 10, ((int)SelectedPlus + 1) * 10);
                    num2 = Random.Range((int)SelectedPlus * 10, num1);
                }
                break;
            case MathOperator.keer:
                if (SelectedKeer == KeerOption.random)
                {
                    op = '*';
                    break;
                }
                else
                {
                    op = '*';
                    num1 = (int)SelectedKeer + 1;
                    break;
                }
            case MathOperator.deel:
                if (SelectedDeel == DeelOption.random)
                {
                    op = '/';
                    int num3 = num1 * num2;
                    num1 = num3;
                    break;

                }
                else
                {
                    op = '/';
                    num2 = (int)SelectedDeel + 1;
                    int num3 = num1 * num2;
                    num1 = num3;
                    break;
                }

        }
        string problemText = string.Format("{0} {1} {2} = ?", num1, op, num2);
        if (problemText == previousProblem)
        {
            GenerateQuestion();
            return;
        }
        previousProblem = problemText;

        question.color = Color.white;
        question.text = problemText;
        if (GenerateObjectEvent != null)
        {
            GenerateObjectEvent("generated string");
        }
        GenerateAnswer();
    }

    /*    void GenerateAnswer()
        {
            *//*        int correctAnswer = 0;
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
                        case '/':
                            correctAnswer = num1 / num2;
                            break;
                    }

                    if (GameModeController.settings.sabermode == 1)
                    {
                        answerOptions = new int[3];
                    }
                    else
                    {
                        answerOptions = new int[4];
                    }

                    for (int i = 0; i < answerOptions.Length; i++)
                    {
                        if (i == correctAnswerIndex)
                        {
                            answerOptions[i] = correctAnswer;
                        }
                        else
                        {
                            int offset = Random.Range(1, 4);
                            if (Random.Range(0, 2) == 0)
                            {
                                answerOptions[i] = correctAnswer + offset;
                            }
                            else
                            {
                                answerOptions[i] = correctAnswer - offset;
                            }
                        }
                    }

                    Shuffle(answerOptions);

                    for (int i = 0; i < answerTexts.Count; i++)
                    {
                        answerTexts[i].SetText(answerOptions[i].ToString());
                    }*//*

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
                case '/':
                    correctAnswer = num1 / num2;
                    break;
            }

            int numOptions = (GameModeController.settings.sabermode == 1) ? 3 : 4;
            answerOptions = new int[numOptions];

            for (int i = 0; i < numOptions; i++)
            {
                if (i == correctAnswerIndex)
                {
                    answerOptions[i] = correctAnswer;
                }
                else
                {
                    int offset = Random.Range(1, 4);
                    int randomSign = Random.Range(0, 2);
                    answerOptions[i] = correctAnswer + (randomSign == 0 ? offset : -offset);
                }
            }

            Shuffle(answerOptions);

            for (int i = 0; i < answerTexts.Count; i++)
            {
                answerTexts[i].SetText(answerOptions[i].ToString());
            }


        }
*/

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
            case '/':
                correctAnswer = num1 / num2;
                break;
        }

        int numOptions = (GameModeController.settings.sabermode == 1) ? 3 : 4;
        answerOptions = new int[numOptions];

        List<int> possibleOptions = new List<int>();
        possibleOptions.Add(correctAnswer);

        for (int i = 0; i < numOptions - 1; i++)
        {
            int offset = Random.Range(1, 4);
            int randomSign = Random.Range(0, 2);
            int option = correctAnswer + (randomSign == 0 ? offset : -offset);

            while (possibleOptions.Contains(option))
            {
                offset = Random.Range(1, 4);
                randomSign = Random.Range(0, 2);

                option = correctAnswer + (randomSign == 0 ? offset : -offset);
            }
            possibleOptions.Add(option);
        }
        answerOptions = possibleOptions.ToArray();

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
        isAnswered = true;
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
            case '/':
                correctAnswer = num1 / num2;
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
            string problemText = string.Format("{0} {1} {2} = {3}", num1, op, num2, correctAnswer);
            if (!wrongAnswers.Contains(problemText))
            {
                wrongAnswers.Add(problemText);
            }
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
            case '/':
                correctAnswer = num1 / num2;
                break;
        }
        string problemText = string.Format("{0} {1} {2} = {3}", num1, op, num2, correctAnswer);
        question.text = problemText;

    }

    IEnumerator StartGame()
    {
        float timeLeft = 3.0f;
        while (timeLeft >= 0)
        {
            question.text = Mathf.RoundToInt(timeLeft).ToString();
            yield return new WaitForSeconds(1.0f);
            timeLeft -= 1.0f;
        }
        timerCoroutine = StartCoroutine(QuestionTimer());
    }

    IEnumerator QuestionTimer()
    {
        while (counter.questionCount < counter.maxQuestionCount)
        {
            GenerateQuestion();
            yield return new WaitForSeconds(cubeSpawner.GetSpawnTime());
            if (!isAnswered)
            {
                score.GetScores(false);
                counter.questionCount++;
                ShowCorrectAnswer();
                if (!wrongAnswers.Contains(question.text))
                {
                    wrongAnswers.Add(question.text);
                }
                question.color = Color.red;
                yield return new WaitForSeconds(2.0f);
            }
        }
        timerCoroutine = StartCoroutine(EndGameDelay());
    }

    IEnumerator ShowQuestionDelayed()
    {
        ShowCorrectAnswer();
        yield return new WaitForSeconds(2.0f);
        isAnswered = false;
        canTrigger = true;
        timerCoroutine = StartCoroutine(QuestionTimer());
    }

    IEnumerator EndGameDelay()
    {
        yield return new WaitForSeconds(2.0f);
        counter.EndGame();
    }

    public void ShowQuesionAnswer()
    {
        StopCoroutine(timerCoroutine);
        timerCoroutine = StartCoroutine(ShowQuestionDelayed());
    }

}
