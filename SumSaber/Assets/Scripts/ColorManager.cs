using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LightSaberColors;

public class ColorManager : MonoBehaviour
{
    public Renderer renderer_RightSaber; 
    [SerializeField] Material material_RightSaber_Red;
    [SerializeField] Material material_RightSaber_Green;

    void Start()
    {
       
        switch (LightSaberColors.SelectedRightHandSaber)
        {
            case RightHandSaber.red:
                renderer_RightSaber.material = material_RightSaber_Red;
                break;
            case RightHandSaber.green:
                renderer_RightSaber.material=material_RightSaber_Green;
                break;
        }
    }
}
