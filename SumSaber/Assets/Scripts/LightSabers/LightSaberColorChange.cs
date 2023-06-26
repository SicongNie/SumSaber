using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This script is used to change the color of the lightsabers and the buttons in the menu
public class LightSaberColorChange : MonoBehaviour
{
    public enum RightHandSaber { red, green, yellow }
    public static RightHandSaber SelectedRightHandSaber;

    public enum LeftHandSaber { blue, orange, purple }
    public static LeftHandSaber SelectedLeftHandSaber;

    public Button Button_Right_Red;
    public Button Button_Right_Green;
    public Button Button_Right_Yellow;

    public Button Button_Left_Blue;
    public Button Button_Left_Orange;
    public Button Button_Left_Purple;

    private void Start()
    {
        UpdateButtonOptions_Right();
        UpdateButtonOptions_Left();
    }

    public void ChangeColor_RightHand(int index)
    {
        switch (index)
        {
            case 1:
                SelectedRightHandSaber = RightHandSaber.red;
                break;
            case 2:
                SelectedRightHandSaber = RightHandSaber.green;
                break;
            case 3:
                SelectedRightHandSaber = RightHandSaber.yellow;
                break;
            default:
                SelectedRightHandSaber = RightHandSaber.red;
                break;
        }
        UpdateButtonOptions_Right();
    }

    public void ChangeColor_LeftHand(int index)
    {
        switch (index)
        {
            case 1:
                SelectedLeftHandSaber = LeftHandSaber.blue;
                break;
            case 2:
                SelectedLeftHandSaber = LeftHandSaber.orange;
                break;
            case 3:
                SelectedLeftHandSaber = LeftHandSaber.purple;
                break;
            default:
                SelectedLeftHandSaber = LeftHandSaber.blue;
                break;
        }
        UpdateButtonOptions_Left();
    }

    // This method updates the button options for the right hand saber based on the selected color, you can see the selected color by the highlighted button
    private void UpdateButtonOptions_Right()
    {
        if (SelectedRightHandSaber == RightHandSaber.red)
        {
            Button_Right_Red.transform.GetChild(0).gameObject.SetActive(true);
            Button_Right_Green.transform.GetChild(0).gameObject.SetActive(false);
            Button_Right_Yellow.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if (SelectedRightHandSaber == RightHandSaber.green)
        {
            Button_Right_Red.transform.GetChild(0).gameObject.SetActive(false);
            Button_Right_Green.transform.GetChild(0).gameObject.SetActive(true);
            Button_Right_Yellow.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if (SelectedRightHandSaber == RightHandSaber.yellow)
        {
            Button_Right_Red.transform.GetChild(0).gameObject.SetActive(false);
            Button_Right_Green.transform.GetChild(0).gameObject.SetActive(false);
            Button_Right_Yellow.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    // This method updates the button options for the left hand saber based on the selected color, you can see the selected color by the highlighted button
    private void UpdateButtonOptions_Left()
    {
        if (SelectedLeftHandSaber == LeftHandSaber.blue)
        {
            Button_Left_Blue.transform.GetChild(0).gameObject.SetActive(true);
            Button_Left_Orange.transform.GetChild(0).gameObject.SetActive(false);
            Button_Left_Purple.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if (SelectedLeftHandSaber == LeftHandSaber.orange)
        {
            Button_Left_Blue.transform.GetChild(0).gameObject.SetActive(false);
            Button_Left_Orange.transform.GetChild(0).gameObject.SetActive(true);
            Button_Left_Purple.transform.GetChild(0).gameObject.SetActive(false);
        }
        else if (SelectedLeftHandSaber == LeftHandSaber.purple)
        {
            Button_Left_Blue.transform.GetChild(0).gameObject.SetActive(false);
            Button_Left_Orange.transform.GetChild(0).gameObject.SetActive(false);
            Button_Left_Purple.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
