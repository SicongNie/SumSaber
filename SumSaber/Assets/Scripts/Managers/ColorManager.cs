using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LightSaberColorChange;


//This script is used to update the color of the sabers in the game scene based on the selected color in the script LightSaberColorChange.cs
public class ColorManager : MonoBehaviour
{
    [SerializeField] public Renderer renderer_RightSaber;  // Player\XR Orign\Camera Offset\RightHand Controller\Lightsaber_Right\Parent\Blade
    [SerializeField] Material material_RightSaber_Red;     // folder: Assets\Resources\Material\sabers\Red
    [SerializeField] Material material_RightSaber_Green;   // folder: Assets\Resources\Material\sabers\Green
    [SerializeField] Material material_RightSaber_Yellow;  // folder: Assets\Resources\Material\sabers\Yellow

    [SerializeField] public Renderer renderer_LeftSaber;  // Player\XR Orign\Camera Offset\LeftHand Controller\Lightsaber_Left\Parent\Blade
    [SerializeField] Material material_LeftSaber_Blue;    // folder: Assets\Resources\Material\sabers\Blue
    [SerializeField] Material material_LeftSaber_Orange;  // folder: Assets\Resources\Material\sabers\Orange
    [SerializeField] Material material_LeftSaber_Purple;  // folder: Assets\Resources\Material\sabers\Purple

    //Color change for bands in game scene
    [SerializeField] Renderer rightband;  // Env\Platforms\Platform_Cubes\Right_Band
    [SerializeField] Renderer leftband;   // Env\Platforms\Platform_Cubes\Left_Band

    void Start()
    {
        // Update the color of the right hand saber and bands based on the selected color
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

        // Update the color of the left hand saber and bands based on the selected color
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
