using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LightSaberColorChange;

public class ColorManager : MonoBehaviour
{

    public Renderer renderer_RightSaber;
    [SerializeField] Material material_RightSaber_Red;
    [SerializeField] Material material_RightSaber_Green;
    [SerializeField] Material material_RightSaber_Yellow;

    public Renderer renderer_LeftSaber;
    [SerializeField] Material material_LeftSaber_Blue;
    [SerializeField] Material material_LeftSaber_Orange;
    [SerializeField] Material material_LeftSaber_Purple;

    [SerializeField] Renderer rightband;
    [SerializeField] Renderer leftband;

    void Start()
    {
        switch (LightSaberColorChange.SelectedRightHandSaber)
        {
            case RightHandSaber.red:
                renderer_RightSaber.material = material_RightSaber_Red;
                if (GameModeController.settings.sabermode == 0)
                {
                    rightband.material = material_RightSaber_Red;
                }
                else if (GameModeController.settings.sabermode == 1)
                {
                    rightband.material = material_RightSaber_Red;
                    leftband.material = material_RightSaber_Red;
                }
                break;
            case RightHandSaber.green:
                renderer_RightSaber.material = material_RightSaber_Green;
                if (GameModeController.settings.sabermode == 0)
                {
                    rightband.material = material_RightSaber_Green;
                }
                else if (GameModeController.settings.sabermode == 1)
                {
                    rightband.material = material_RightSaber_Green;
                    leftband.material = material_RightSaber_Green;
                }
                break;
            case RightHandSaber.yellow:
                renderer_RightSaber.material = material_RightSaber_Yellow;
                if (GameModeController.settings.sabermode == 0)
                {
                    rightband.material = material_RightSaber_Yellow;
                }
                else if (GameModeController.settings.sabermode == 1)
                {
                    rightband.material = material_RightSaber_Yellow;
                    leftband.material = material_RightSaber_Yellow;
                }
                break;
        }

        switch (LightSaberColorChange.SelectedLeftHandSaber)
        {
            case LeftHandSaber.blue:
                renderer_LeftSaber.material = material_LeftSaber_Blue;
                if (GameModeController.settings.sabermode == 0)
                {
                    leftband.material = material_LeftSaber_Blue;
                }                
                break;
            case LeftHandSaber.orange:
                renderer_LeftSaber.material = material_LeftSaber_Orange;
                if (GameModeController.settings.sabermode == 0)
                {
                    leftband.material = material_LeftSaber_Orange;
                }
                break;
            case LeftHandSaber.purple:
                renderer_LeftSaber.material = material_LeftSaber_Purple;
                if (GameModeController.settings.sabermode == 0)
                {
                    leftband.material = material_LeftSaber_Purple;
                }
                break;
        }

    }

}
