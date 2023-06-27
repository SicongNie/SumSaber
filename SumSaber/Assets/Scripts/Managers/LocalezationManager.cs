using CarouselUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

// This script manages the languages of the game
public class LocalezationManager : MonoBehaviour
{
    private bool active = false;

    public static bool isTriggered;
    public static LocalezationManager instance;

    private void Awake()
    {
        // Ensures only one instance of the LocalizationManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Change the locale when the LocalizationManager is created
        ChangeLocale();
    }

    private void Update()
    {
        // Check if the localization change is triggered
        if (isTriggered == true)
        {
            ChangeLocale();
            isTriggered = false;
        }
    }
    public void ChangeLocale()
    {
        if (active == true)
            return;
        // Start the coroutine to change the locale based on the current index of the CarouselUIElement
        StartCoroutine(SetLocale(CarouselUIElement._currentIndex));
    }

    IEnumerator SetLocale(int localID)
    {
        // Set the active flag to prevent simultaneous localization changes
        active = true;

        // Wait for the initialization of the localization system
        yield return LocalizationSettings.InitializationOperation;

        // Set the selected locale to the one specified by the localID
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localID];

        // Reset the active flag
        active = false;
    }
}
