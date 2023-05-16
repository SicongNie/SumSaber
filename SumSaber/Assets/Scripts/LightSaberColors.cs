using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSaberColors : MonoBehaviour
{
    public enum RightHandSaber { red,green,yellow}
    public static RightHandSaber SelectedRightHandSaber;

    public enum LeftHandSaber { blue, orange, purple }
    public static LeftHandSaber SelectedLeftHandSaber;

    public Button Button_Right_Red;
    public Button Button_Right_Green;
    public Button Button_Right_Yellow;
    public Button Button_Right_Blue;
    public Button Button_Right_Orange;
    public Button Button_Right_Purple;

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
    }

    private void UpdateButtonOptions_Right()
    {

    }

    private void UpdateButtonOptions_Left()
    {

    }



}
