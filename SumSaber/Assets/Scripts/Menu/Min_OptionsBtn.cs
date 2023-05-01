using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameModeController;

public class Min_OptionsBtn : MonoBehaviour
{
    public Button optionButton_min_10;
    public Button optionButton_min_20;
    public Button optionButton_min_30;
    public Button optionButton_min_40;
    public Button optionButton_min_50;
    public Button optionButton_min_60;
    public Button optionButton_min_70;
    public Button optionButton_min_80;
    public Button optionButton_min_90;
    public Button optionButton_min_100;


    private void Start()
    {
        UpdateButtonOptions_min();
    }

    public void OnMinOptionButtonClick(int num)
    {
        switch (num)
        {
            case 1:
                SelectedMin = MinOption.Min10;
                break;
            case 2:
                SelectedMin = MinOption.Min20;
                break;
            case 3:
                SelectedMin = MinOption.Min30;
                break;
            case 4:
                SelectedMin = MinOption.Min40;
                break;
            case 5:
                SelectedMin = MinOption.Min50;
                break;
            case 6:
                SelectedMin = MinOption.Min60;
                break;
            case 7:
                SelectedMin = MinOption.Min70;
                break;
            case 8:
                SelectedMin = MinOption.Min80;
                break;
            case 9:
                SelectedMin = MinOption.Min90;
                break;
            case 10:
                SelectedMin = MinOption.Min100;
                break;
            default:
                SelectedMin = MinOption.Min10;
                break;
        }
        UpdateButtonOptions_min();
    }


    void UpdateButtonOptions_min()
    {
        Image optionbutton_min_1 = optionButton_min_10.GetComponent<Image>();
        Image optionbutton_min_2 = optionButton_min_20.GetComponent<Image>();
        Image optionbutton_min_3 = optionButton_min_30.GetComponent<Image>();
        Image optionbutton_min_4 = optionButton_min_40.GetComponent<Image>();
        Image optionbutton_min_5 = optionButton_min_50.GetComponent<Image>();
        Image optionbutton_min_6 = optionButton_min_60.GetComponent<Image>();
        Image optionbutton_min_7 = optionButton_min_70.GetComponent<Image>();
        Image optionbutton_min_8 = optionButton_min_80.GetComponent<Image>();
        Image optionbutton_min_9 = optionButton_min_90.GetComponent<Image>();
        Image optionbutton_min_10 = optionButton_min_100.GetComponent<Image>();

        if (SelectedMin == MinOption.Min10)
        {
            optionbutton_min_1.color = Color.gray;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min20)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.gray;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min30)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.gray;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min40)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.gray;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min50)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.gray;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min60)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.gray;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min70)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.gray;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min80)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.gray;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min90)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.gray;
            optionbutton_min_10.color = Color.white;
        }
        else if (SelectedMin == MinOption.Min100)
        {
            optionbutton_min_1.color = Color.white;
            optionbutton_min_2.color = Color.white;
            optionbutton_min_3.color = Color.white;
            optionbutton_min_4.color = Color.white;
            optionbutton_min_5.color = Color.white;
            optionbutton_min_6.color = Color.white;
            optionbutton_min_7.color = Color.white;
            optionbutton_min_8.color = Color.white;
            optionbutton_min_9.color = Color.white;
            optionbutton_min_10.color = Color.gray;
        }
    }

}
