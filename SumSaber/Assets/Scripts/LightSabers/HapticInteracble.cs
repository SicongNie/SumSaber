using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

//This script is used to trigger haptic feedback on the controllers
public class HapticInteracble : MonoBehaviour
{
    [Range(0, 1)]
    public float intensity;
    public float duration;

    private XRBaseController controller;

    void Start()
    {
       // XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        controller = GetComponent<XRBaseController>();
    }

    
    public void TriggerHaptic()
    {
        if (intensity > 0)
        {
            // Send a haptic impulse with the specified intensity and duration.
            controller.SendHapticImpulse(intensity, duration);
        }
    }

}
