using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

//Script for various audio-related tasks 
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [Header("Audio Sources")]
    [SerializeField] AudioSource musicSource;                    // AudioManager/Music(AudioSource)
    [SerializeField] AudioSource sfxSource;                      // AudioManager/SFX(AudioSource)
    [SerializeField] AudioSource sfxSource_Countdown;            // AudioManager/Countdown(AudioSource)

    [Header("Audio Clips")]
    [SerializeField] public AudioClip background;                                 // folder: Assets/Resources/Sounds/SumSaber_Track1.wav
    [SerializeField] public AudioClip menu;                                       // folder: Assets/Resources/Sounds/Menu.wav
    [SerializeField] public AudioClip button_press;                               // folder: Assets/Resources/Sounds/Button_Press.wav
    [SerializeField] public AudioClip button_hover;                               // folder: Assets/Resources/Sounds/Button_Hover.wav

     [SerializeField] public AudioClip CountDown;                                  // folder: Assets/Resources/Sounds/Countdown.wav

    [Header("Audio Mixer")]
    [SerializeField] public AudioMixer myMixer;                                   //folder: Assets/Resources/Sounds/AudioMixer.mixer

    //Make sure the audio manager is not destroyed when changing scenes
    //And make sure there is only one instance of the audio manager
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic(menu);

        //Set volume of backgrond music and sfx
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            float volume = PlayerPrefs.GetFloat("MusicVolume");
            myMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        }
        if (PlayerPrefs.HasKey("SFXVolume"))
        {
            float volume = PlayerPrefs.GetFloat("SFXVolume");
            myMixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
            myMixer.SetFloat("countdown", Mathf.Log10(volume) * 20);
        }

    }

    //play audio clips
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void PlayCountdown(AudioClip clip)
    {
        sfxSource_Countdown.PlayOneShot(clip);
    }

    //keep the music playing between scenes
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 1)
        {
            musicSource.clip = background;
            musicSource.Play();
        }
        else
        {
            musicSource.clip = menu;
        }
    }
}
