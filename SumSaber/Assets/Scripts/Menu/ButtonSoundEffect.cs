using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// This script is used to play sound effects when the buttons are pressed or hovered over
public class ButtonSoundEffect : MonoBehaviour, IPointerEnterHandler
{
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void PlayPressedClip()
    {
        audioManager.PlaySFX(audioManager.button_press);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioManager.PlaySFX(audioManager.button_hover);
    }

}
