using UnityEngine;
using UnityEngine.UI;
using static GameModeController;

public class Keer_OptionBtn : MonoBehaviour
{
    public Button optionButton_keer_1;
    public Button optionButton_keer_2;
    public Button optionButton_keer_3;
    public Button optionButton_keer_4;
    public Button optionButton_keer_5;
    public Button optionButton_keer_6;
    public Button optionButton_keer_7;
    public Button optionButton_keer_8;
    public Button optionButton_keer_9;
    public Button optionButton_keer_random;


    private void Start()
    {
        UpdateButtonOptions_keer();
    }

    public void OnKeerOptionButtonClick(int num)
    {
        switch (num)
        {
            case 1:
                SelectedKeer = KeerOption.X1;
                break;
            case 2:
                SelectedKeer = KeerOption.X2;
                break;
            case 3:
                SelectedKeer = KeerOption.X3;
                break;
            case 4:
                SelectedKeer = KeerOption.X4;
                break;
            case 5:
                SelectedKeer = KeerOption.X5;
                break;
            case 6:
                SelectedKeer = KeerOption.X6;
                break;
            case 7:
                SelectedKeer = KeerOption.X7;
                break;
            case 8:
                SelectedKeer = KeerOption.X8;
                break;
            case 9:
                SelectedKeer = KeerOption.X9;
                break;
            case 10:
                SelectedKeer = KeerOption.random;
                break;
            default:
                SelectedKeer = KeerOption.X1;
                break;
        }
        UpdateButtonOptions_keer();
    }

    void UpdateButtonOptions_keer()
    {
        Image optionbutton_keer_1 = optionButton_keer_1.GetComponent<Image>();
        Image optionbutton_keer_2 = optionButton_keer_2.GetComponent<Image>();
        Image optionbutton_keer_3 = optionButton_keer_3.GetComponent<Image>();
        Image optionbutton_keer_4 = optionButton_keer_4.GetComponent<Image>();
        Image optionbutton_keer_5 = optionButton_keer_5.GetComponent<Image>();
        Image optionbutton_keer_6 = optionButton_keer_6.GetComponent<Image>();
        Image optionbutton_keer_7 = optionButton_keer_7.GetComponent<Image>();
        Image optionbutton_keer_8 = optionButton_keer_8.GetComponent<Image>();
        Image optionbutton_keer_9 = optionButton_keer_9.GetComponent<Image>();
        Image optionbutton_keer_random = optionButton_keer_random.GetComponent<Image>();

        string htmlColor = "#63F578";
        string htmlColor2 = "#59B966";
        Color color;
        Color color2;
        ColorUtility.TryParseHtmlString(htmlColor, out color);
        ColorUtility.TryParseHtmlString(htmlColor2, out color2);


        if (SelectedKeer == KeerOption.X1)
        {
            optionbutton_keer_1.color = color2;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.X2)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color2;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.X3)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color2;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.X4)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color2;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.X5)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color2;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.X6)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color2;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.X7)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color2;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.X8)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color2;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.X9)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color2;
            optionbutton_keer_random.color = color;
        }
        else if (SelectedKeer == KeerOption.random)
        {
            optionbutton_keer_1.color = color;
            optionbutton_keer_2.color = color;
            optionbutton_keer_3.color = color;
            optionbutton_keer_4.color = color;
            optionbutton_keer_5.color = color;
            optionbutton_keer_6.color = color;
            optionbutton_keer_7.color = color;
            optionbutton_keer_8.color = color;
            optionbutton_keer_9.color = color;
            optionbutton_keer_random.color = color2;
        }
    }
}
