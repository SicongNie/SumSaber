using CarouselUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    private bool active = false;

    public static bool isTriggered;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        ChangeLocale();
    }

    private void Update()
    {
        if(isTriggered == true)
        {
            ChangeLocale();
            isTriggered = false;
        }
    }
    public void ChangeLocale()
    {
        if (active == true)
            return;
        StartCoroutine(SetLocale(CarouselUIElement._currentIndex));
    }

    IEnumerator SetLocale(int localID)
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localID];
       // PlayerPrefs.SetInt("LocaleKey", localID);
        active = false;
    }
}
