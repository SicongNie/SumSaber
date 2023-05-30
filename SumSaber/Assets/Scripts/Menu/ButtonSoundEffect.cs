using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
