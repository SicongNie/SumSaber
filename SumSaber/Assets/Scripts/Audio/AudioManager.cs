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
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;
    [SerializeField] AudioSource sfxSource_Countdown;

    [Header("Audio Clips")]
    public AudioClip background;
    public AudioClip menu;
    public AudioClip button_press;
    public AudioClip button_hover;

    public AudioClip CountDown;

    [Header("Audio Mixer")]
    public AudioMixer myMixer;

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
