using CarouselUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalezationManager : MonoBehaviour
{
    private bool active = false;

    public static bool isTriggered;
    public static LocalezationManager instance;

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
        active = false;
    }
}
