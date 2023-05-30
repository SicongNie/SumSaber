using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameModeController;

public class Deel_OptionsBtn_ColorChange : MonoBehaviour
{
    [SerializeField] Button optionButton_deel_1;
    [SerializeField] Button optionButton_deel_2;
    [SerializeField] Button optionButton_deel_3;
    [SerializeField] Button optionButton_deel_4;
    [SerializeField] Button optionButton_deel_5;
    [SerializeField] Button optionButton_deel_6;
    [SerializeField] Button optionButton_deel_7;
    [SerializeField] Button optionButton_deel_8;
    [SerializeField] Button optionButton_deel_9;
    [SerializeField] Button optionButton_deel_random;


    private void Start()
    {
        UpdateButtonOptions_Deel();
    }

    public void OnDeelOptionButtonClick(int num)
    {
        switch (num)
        {
            case 1:
                SelectedDeel = DeelOption.Deel1;
                break;
            case 2:
                SelectedDeel = DeelOption.Deel2;
                break;
            case 3:
                SelectedDeel = DeelOption.Deel3;
                break;
            case 4:
                SelectedDeel = DeelOption.Deel4;
                break;
            case 5:
                SelectedDeel = DeelOption.Deel5;
                break;
            case 6:
                SelectedDeel = DeelOption.Deel6;
                break;
            case 7:
                SelectedDeel = DeelOption.Deel7;
                break;
            case 8:
                SelectedDeel = DeelOption.Deel8;
                break;
            case 9:
                SelectedDeel = DeelOption.Deel9;
                break;
            case 10:
                SelectedDeel = DeelOption.random;
                break;
            default:
                SelectedDeel = DeelOption.Deel1;
                break;
        }
        UpdateButtonOptions_Deel();
    }

    void UpdateButtonOptions_Deel()
    {
        Image optionbutton_deel_1 = optionButton_deel_1.GetComponent<Image>();
        Image optionbutton_deel_2 = optionButton_deel_2.GetComponent<Image>();
        Image optionbutton_deel_3 = optionButton_deel_3.GetComponent<Image>();
        Image optionbutton_deel_4 = optionButton_deel_4.GetComponent<Image>();
        Image optionbutton_deel_5 = optionButton_deel_5.GetComponent<Image>();
        Image optionbutton_deel_6 = optionButton_deel_6.GetComponent<Image>();
        Image optionbutton_deel_7 = optionButton_deel_7.GetComponent<Image>();
        Image optionbutton_deel_8 = optionButton_deel_8.GetComponent<Image>();
        Image optionbutton_deel_9 = optionButton_deel_9.GetComponent<Image>();
        Image optionbutton_deel_random = optionButton_deel_random.GetComponent<Image>();

        string htmlColor = "#FF625E";
        string htmlColor2 = "#B74340";
        Color color;
        Color color2;
        ColorUtility.TryParseHtmlString(htmlColor, out color);
        ColorUtility.TryParseHtmlString(htmlColor2, out color2);

        if (SelectedDeel == DeelOption.Deel1)
        {
            optionbutton_deel_1.color = color2;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.Deel2)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color2;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.Deel3)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color2;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.Deel4)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color2;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.Deel5)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color2;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.Deel6)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color2;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.Deel7)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color2;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.Deel8)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color2;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.Deel9)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color2;
            optionbutton_deel_random.color = color;
        }
        else if (SelectedDeel == DeelOption.random)
        {
            optionbutton_deel_1.color = color;
            optionbutton_deel_2.color = color;
            optionbutton_deel_3.color = color;
            optionbutton_deel_4.color = color;
            optionbutton_deel_5.color = color;
            optionbutton_deel_6.color = color;
            optionbutton_deel_7.color = color;
            optionbutton_deel_8.color = color;
            optionbutton_deel_9.color = color;
            optionbutton_deel_random.color = color2;
        }
    }
}
