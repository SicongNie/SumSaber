using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSoundEffect : MonoBehaviour, IPointerEnterHandler
{
    public AudioClip hoverClip;
    public AudioClip pressedClip;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayPressedClip()
    {
        audioSource.clip = pressedClip;
        audioSource.Play();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.clip = hoverClip;
        audioSource.Play();
    }

}
