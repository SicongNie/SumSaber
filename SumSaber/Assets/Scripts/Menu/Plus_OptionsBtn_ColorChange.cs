using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameModeController;

public class Plus_OptionsBtn_ColorChange : MonoBehaviour
{
    [SerializeField] Button optionButton_plus_10;
    [SerializeField] Button optionButton_plus_20;
    [SerializeField] Button optionButton_plus_30;
    [SerializeField] Button optionButton_plus_40;
    [SerializeField] Button optionButton_plus_50;
    [SerializeField] Button optionButton_plus_60;
    [SerializeField] Button optionButton_plus_70;
    [SerializeField] Button optionButton_plus_80;
    [SerializeField] Button optionButton_plus_90;
    [SerializeField] Button optionButton_plus_100;

    private void Start()
    {
        UpdateButtonOptions_plus();
    }

    public void OnPlusOptionButtonClick(int num)
    {
        switch (num)
        {
            case 1:
                SelectedPlus = PlusOption.Plus10;
                break;
            case 2:
                SelectedPlus = PlusOption.Plus20;
                break;
            case 3:
                SelectedPlus = PlusOption.Plus30;
                break;
            case 4:
                SelectedPlus = PlusOption.Plus40;
                break;
            case 5:
                SelectedPlus = PlusOption.Plus50;
                break;
            case 6:
                SelectedPlus = PlusOption.Plus60;
                break;
            case 7:
                SelectedPlus = PlusOption.Plus70;
                break;
            case 8:
                SelectedPlus = PlusOption.Plus80;
                break;
            case 9:
                SelectedPlus = PlusOption.Plus90;
                break;
            case 10:
                SelectedPlus = PlusOption.Plus100;
                break;
            default:
                SelectedPlus = PlusOption.Plus10;
                break;
        }
        UpdateButtonOptions_plus();
    }


    void UpdateButtonOptions_plus()
    {
        Image optionbutton_plus_1 = optionButton_plus_10.GetComponent<Image>();
        Image optionbutton_plus_2 = optionButton_plus_20.GetComponent<Image>();
        Image optionbutton_plus_3 = optionButton_plus_30.GetComponent<Image>();
        Image optionbutton_plus_4 = optionButton_plus_40.GetComponent<Image>();
        Image optionbutton_plus_5 = optionButton_plus_50.GetComponent<Image>();
        Image optionbutton_plus_6 = optionButton_plus_60.GetComponent<Image>();
        Image optionbutton_plus_7 = optionButton_plus_70.GetComponent<Image>();
        Image optionbutton_plus_8 = optionButton_plus_80.GetComponent<Image>();
        Image optionbutton_plus_9 = optionButton_plus_90.GetComponent<Image>();
        Image optionbutton_plus_10 = optionButton_plus_100.GetComponent<Image>();

        string htmlColor = "#28EAFF";
        string htmlColor2 = "#1A94A2";
        Color color;
        Color color2;
        ColorUtility.TryParseHtmlString(htmlColor, out color);
        ColorUtility.TryParseHtmlString(htmlColor2, out color2);

        if (SelectedPlus == PlusOption.Plus10)
        {
            optionbutton_plus_1.color = color2;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color= color;
        }
        else if (SelectedPlus == PlusOption.Plus20)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color2;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color = color;
        }
        else if (SelectedPlus == PlusOption.Plus30)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color2;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color = color;
        }
        else if (SelectedPlus == PlusOption.Plus40)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color2;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color = color;
        }
        else if (SelectedPlus == PlusOption.Plus50)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color2;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color = color;
        }
        else if (SelectedPlus == PlusOption.Plus60)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color2;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color = color;

        }
        else if (SelectedPlus == PlusOption.Plus70)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color2;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color = color;
        }
        else if (SelectedPlus == PlusOption.Plus80)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color2;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color = color;
        }
        else if (SelectedPlus == PlusOption.Plus90)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color2;
            optionbutton_plus_10.color = color;
        }
        else if (SelectedPlus == PlusOption.Plus100)
        {
            optionbutton_plus_1.color = color;
            optionbutton_plus_2.color = color;
            optionbutton_plus_3.color = color;
            optionbutton_plus_4.color = color;
            optionbutton_plus_5.color = color;
            optionbutton_plus_6.color = color;
            optionbutton_plus_7.color = color;
            optionbutton_plus_8.color = color;
            optionbutton_plus_9.color = color;
            optionbutton_plus_10.color = color2;
        }
    }

}
