using CarouselUI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//This script is responsible for setting the game modes and options, and updating the button statuses accordingly
public class GameModeController : MonoBehaviour
{
    //Game modes 
    public enum MathOperator { plus, min, keer, deel }
    public static MathOperator SelectedOperator;
    public static GameSettings settings;

    //options of plusmode 
    public enum PlusOption { Plus10, Plus20, Plus30, Plus40, Plus50, Plus60, Plus70, Plus80, Plus90, Plus100 }
    public static PlusOption SelectedPlus;

    //options of minmode
    public enum MinOption { Min10, Min20, Min30, Min40, Min50, Min60, Min70, Min80, Min90, Min100 }
    public static MinOption SelectedMin;

    //options of keermode
    public enum KeerOption { X1, X2, X3, X4, X5, X6, X7, X8, X9, X10, random }
    public static KeerOption SelectedKeer;

    //options of deelmode
    public enum DeelOption { Deel1, Deel2, Deel3, Deel4, Deel5, Deel6, Deel7, Deel8, Deel9, random }
    public static DeelOption SelectedDeel;

    //title of the game modes
    [SerializeField] private TextMeshProUGUI textMeshPro;               //Options Canavs\Text\Title

    //explanation of the game modes --> more details see this script: Assets\Scripts\Menu\DetailsMultiLanguages.cs
    [SerializeField] private TextMeshProUGUI detailText;               // Options Canavs\Text\Detail

    //buttons in Options Canvas
    [SerializeField] Button numQuestions10Button;                     // Options Canavs\Buttons\10_Btn
    [SerializeField] Button numQuestions30Button;                     // Options Canavs\Buttons\30_Btn
    [SerializeField] Button numQuestions50Button;                     // Options Canavs\Buttons\50_Btn

    [SerializeField] Button generationSpeedButton_easy;               // Options Canavs\Buttons\Easy_Btn
    [SerializeField] Button generationSpeedButton_normal;             // Options Canavs\Buttons\Normal_Btn
    [SerializeField] Button generationSpeedButton_hard;               // Options Canavs\Buttons\Hard_Btn

    [SerializeField] Button gameModeButton_NoArrow;                   // Options Canavs\Buttons\NoArrows_Btn
    [SerializeField] Button gameModeButton_Arrow;                     // Options Canavs\Buttons\WithArrows_Btn

    [SerializeField] Button gameModeButton_OneHand;                   // Options Canavs\Buttons\OneHand_Btn
    [SerializeField] Button gameModeButton_TwoHand;                   // Options Canavs\Buttons\TwoHand_Btn


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
        //update the language of the title of the game modes
        if (CarouselUIElement._currentIndex == 0)
        {
            textMeshPro.text = "Modus: " + SelectedOperator.ToString();
        }
        else if (CarouselUIElement._currentIndex == 1)
        {
            if (SelectedOperator.ToString() == "plus")
            {
                textMeshPro.text = "Mode: Plus";
            }

            if (SelectedOperator.ToString() == "min")
            {
                textMeshPro.text = "Mode: Minus";
            }

            if (SelectedOperator.ToString() == "deel")
            {
                textMeshPro.text = "Mode: Divide";
            }

            if (SelectedOperator.ToString() == "keer")
            {
                textMeshPro.text = "Mode: Multiply";
            }
        }
    }

    //Configure the game settings through the OnClick() function of the buttons in the Options Canvas.
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

    //Update the color of the buttons in the Options Canvas according to the current game settings.
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
