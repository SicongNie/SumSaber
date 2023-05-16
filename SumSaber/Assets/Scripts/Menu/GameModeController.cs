using CarouselUI;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

public class GameModeController : MonoBehaviour
{
    public enum MathOperator { plus, min, keer, deel }
    public static MathOperator SelectedOperator;
    public static GameSettings settings;

    public Button numQuestions10Button;
    public Button numQuestions30Button;
    public Button numQuestions50Button;

    public Button generationSpeedButton_easy;
    public Button generationSpeedButton_normal;
    public Button generationSpeedButton_hard;

    public Button gameModeButton_NoArrow;
    public Button gameModeButton_Arrow;

    public Button gameModeButton_OneHand;
    public Button gameModeButton_TwoHand;

    public enum PlusOption { Plus10, Plus20, Plus30, Plus40, Plus50, Plus60, Plus70, Plus80, Plus90, Plus100 }
    public static PlusOption SelectedPlus;

    public enum MinOption { Min10, Min20, Min30, Min40, Min50, Min60, Min70, Min80, Min90, Min100 }
    public static MinOption SelectedMin;

    public enum KeerOption { X1, X2, X3, X4, X5, X6, X7, X8, X9, X10, random }
    public static KeerOption SelectedKeer;

    public enum DeelOption { Deel1, Deel2, Deel3, Deel4, Deel5, Deel6, Deel7, Deel8, Deel9, random }
    public static DeelOption SelectedDeel;

    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private TextMeshProUGUI detailText;


    void Start()
    {
        settings.numQuestions = 10;
        settings.generationSpeed = 3.5f;
        settings.gamemode = 0;
        UpdateButtonColors_numQuestions();
        UpdateButtonColors_generationSpeed();
        UpdateButtonColors_gameMode();
        UpdateButtonColors_saberMode();
        detailText.enabled = false;
    }

    private void Update()
    {
        if (CarouselUIElement._currentIndex == 0)
        {
            textMeshPro.text = "Modus: " + SelectedOperator.ToString();
        }
        else if (CarouselUIElement._currentIndex == 1)
        {
            if(SelectedOperator.ToString()== "plus")
            {
                textMeshPro.text = "Mode: plus";
            }

            if(SelectedOperator.ToString() == "min")
            {
                textMeshPro.text = "Mode: min";
            }

            if (SelectedOperator.ToString() == "deel")
            {
                textMeshPro.text = "Mode: divide";
            }


            if (SelectedOperator.ToString() == "keer")
            {
                textMeshPro.text = "Mode: multiply";
            }
        }
    }


    public void OnNumQuestionsButtonClick(int num)
    {
        settings.numQuestions = num;
        UpdateButtonColors_numQuestions();
    }

    public void OnGenerationSpeedButtonClick(float speed)
    {
        settings.generationSpeed = speed;
        UpdateButtonColors_generationSpeed();
    }

    public void OnGamemodeButtonClick(int mode)
    {
        settings.gamemode = mode;
        UpdateButtonColors_gameMode();
    }

    public void OnSabermodeButtonClick(int mode)
    {
        settings.sabermode = mode;
        UpdateButtonColors_saberMode();

    }

    void UpdateButtonColors_numQuestions()
    {
        Image numQuestions10ButtonImage = numQuestions10Button.GetComponent<Image>();
        Image numQuestions30ButtonImage = numQuestions30Button.GetComponent<Image>();
        Image numQuestions50ButtonImage = numQuestions50Button.GetComponent<Image>();

        if (settings.numQuestions == 10)
        {
            numQuestions10ButtonImage.color = new Color(1f, 0f, 0f, .75f);
            numQuestions30ButtonImage.color = new Color(0f, 0f, 0f, .75f);
            numQuestions50ButtonImage.color = new Color(0f, 0f, 0f, .75f);
        }
        else if (settings.numQuestions == 30)
        {
            numQuestions10ButtonImage.color = new Color(0f, 0f, 0f, .75f);
            numQuestions30ButtonImage.color = new Color(1f, 0f, 0f, .75f);
            numQuestions50ButtonImage.color = new Color(0f, 0f, 0f, .75f);
        }
        else if (settings.numQuestions == 50)
        {
            numQuestions10ButtonImage.color = new Color(0f, 0f, 0f, .75f);
            numQuestions30ButtonImage.color = new Color(0f, 0f, 0f, .75f);
            numQuestions50ButtonImage.color = new Color(1f, 0f, 0f, .75f);
        }
    }

    void UpdateButtonColors_generationSpeed()
    {
        Image generationSpeedButton_easyImage = generationSpeedButton_easy.GetComponent<Image>();
        Image generationSpeedButton_normalImage = generationSpeedButton_normal.GetComponent<Image>();
        Image generationSpeedButton_hardImage = generationSpeedButton_hard.GetComponent<Image>();

        if (settings.generationSpeed == 3.5f)
        {
            generationSpeedButton_easyImage.color = new Color(1f, 0f, 0f, .75f);
            generationSpeedButton_normalImage.color = new Color(0f, 0f, 0f, .75f);
            generationSpeedButton_hardImage.color = new Color(0f, 0f, 0f, .75f);
        }
        else if (settings.generationSpeed == 5f)
        {
            generationSpeedButton_easyImage.color = new Color(0f, 0f, 0f, .75f);
            generationSpeedButton_normalImage.color = new Color(1f, 0f, 0f, .75f);
            generationSpeedButton_hardImage.color = new Color(0f, 0f, 0f, .75f);

        }
        else if (settings.generationSpeed == 7f)
        {
            generationSpeedButton_easyImage.color = new Color(0f, 0f, 0f, .75f);
            generationSpeedButton_normalImage.color = new Color(0f, 0f, 0f, .75f);
            generationSpeedButton_hardImage.color = new Color(1f, 0f, 0f, .75f);
        }
    }

    void UpdateButtonColors_gameMode()
    {
        Image gameModeButton_NoArrowImage = gameModeButton_NoArrow.GetComponent<Image>();
        Image gameModeButton_ArrowImage = gameModeButton_Arrow.GetComponent<Image>();


        if (settings.gamemode == 0)
        {
            gameModeButton_NoArrowImage.color = new Color(1f, 0f, 0f, .75f);
            gameModeButton_ArrowImage.color = new Color(0f, 0f, 0f, .75f);
        }
        else if (settings.gamemode == 1)
        {
            gameModeButton_NoArrowImage.color = new Color(0f, 0f, 0f, .75f);
            gameModeButton_ArrowImage.color = new Color(1f, 0f, 0f, .75f);
        }
    }

    void UpdateButtonColors_saberMode()
    {
        Image gameModeButton_TwoHnadImage = gameModeButton_TwoHand.GetComponent<Image>();
        Image gameModeButton_OneHnadImage = gameModeButton_OneHand.GetComponent<Image>();

        if (settings.sabermode == 0)
        {
            gameModeButton_TwoHnadImage.color = new Color(1f, 0f, 0f, .75f);
            gameModeButton_OneHnadImage.color = new Color(0f, 0f, 0f, .75f);
        }
        if (settings.sabermode == 1)
        {
            gameModeButton_TwoHnadImage.color = new Color(0f, 0f, 0f, .75f);
            gameModeButton_OneHnadImage.color = new Color(1f, 0f, 0f, .75f);
        }
    }


}
