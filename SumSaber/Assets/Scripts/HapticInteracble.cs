using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteracble : MonoBehaviour
{
    [Range(0, 1)]
    public float intensity;
    public float duration;

    private XRBaseController controller;

    void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        controller = GetComponent<XRBaseController>();
    }

    public void TriggerHaptic()
    {
        if (intensity > 0)
        {
            controller.SendHapticImpulse(intensity, duration);
        }
    }

}
