using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameModeController;

public class Plus_OptionsBtn : MonoBehaviour
{
    public Button optionButton_plus_10;
    public Button optionButton_plus_20;
    public Button optionButton_plus_30;
    public Button optionButton_plus_40;
    public Button optionButton_plus_50;
    public Button optionButton_plus_60;
    public Button optionButton_plus_70;
    public Button optionButton_plus_80;
    public Button optionButton_plus_90;
    public Button optionButton_plus_100;

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

        if (SelectedPlus == PlusOption.Plus10)
        {
            optionbutton_plus_1.color = Color.gray;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color= Color.white;
        }
        else if (SelectedPlus == PlusOption.Plus20)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.gray;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color = Color.white;
        }
        else if (SelectedPlus == PlusOption.Plus30)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.gray;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color = Color.white;
        }
        else if (SelectedPlus == PlusOption.Plus40)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.gray;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color = Color.white;
        }
        else if (SelectedPlus == PlusOption.Plus50)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.gray;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color = Color.white;
        }
        else if (SelectedPlus == PlusOption.Plus60)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.gray;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color = Color.white;

        }
        else if (SelectedPlus == PlusOption.Plus70)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.gray;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color = Color.white;
        }
        else if (SelectedPlus == PlusOption.Plus80)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.gray;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color = Color.white;
        }
        else if (SelectedPlus == PlusOption.Plus90)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.gray;
            optionbutton_plus_10.color = Color.white;
        }
        else if (SelectedPlus == PlusOption.Plus100)
        {
            optionbutton_plus_1.color = Color.white;
            optionbutton_plus_2.color = Color.white;
            optionbutton_plus_3.color = Color.white;
            optionbutton_plus_4.color = Color.white;
            optionbutton_plus_5.color = Color.white;
            optionbutton_plus_6.color = Color.white;
            optionbutton_plus_7.color = Color.white;
            optionbutton_plus_8.color = Color.white;
            optionbutton_plus_9.color = Color.white;
            optionbutton_plus_10.color = Color.gray;
        }
    }

}
