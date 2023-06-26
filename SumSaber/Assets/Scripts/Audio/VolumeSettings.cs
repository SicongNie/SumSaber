using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

//Here the volume of the music and the sfx is controlled
public class VolumeSettings : MonoBehaviour
{
    AudioManager audioManager;

    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;

    //find audiomanager
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        //set sliders to saved values
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        }

        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        }
    }

    //set volume of music and sfx
    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        audioManager.myMixer.SetFloat("music", Mathf.Log10(volume) * 20); //transform value of slider to logarithmic scale for audio mixer
        PlayerPrefs.SetFloat("MusicVolume", volume); //save music volume
    }

    public void SetSFXVolume()
    {
        float volume = sfxSlider.value;
        audioManager.myMixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
        audioManager.myMixer.SetFloat("countdown", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume); //save sfx volume
    }

}
