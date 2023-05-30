using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CarouselUI;
using TMPro;

public class DetailsMultiLanguages : MonoBehaviour
{

    public void ShowText(int index)
    {
        if (CarouselUIElement._currentIndex == 0)
        {
            if (index == 0)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je hebt in totaal 10 rekensommen";
            }
            if(index == 1)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je hebt in totaal 30 rekensommen";
            }
            if(index == 2)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je hebt in totaal 50 rekensommen";
            }
            if(index == 3)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je speelt met een langzame snelheid";
            }
            if(index == 4)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je speelt met een normale snelheid";
            }
            if (index == 5)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je speelt met een hoge snelheid";
            }
            if (index == 6)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je hoeft alleen het juiste blok te raken";
            }
            if (index == 7)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je moet naast het  juiste antwoord dit ook in de juiste richting doorsnijden";
            }
            if (index == 8)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je speelt met twee lightsabers";
            }
            if (index == 9)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Je speelt met één lightsaber";
            }


        }
        else if (CarouselUIElement._currentIndex == 1)
        {
            if (index == 0)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You have a total of 10 sums";
            }
            if (index == 1)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You have a total of 30 sums";
            }
            if (index == 2)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You have a total of 50 sums";
            }
            if (index == 3)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You play at a slow speed";
            }
            if (index == 4)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You play at a normal speed";
            }
            if (index == 5)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You play at a fast speed";
            }
            if (index == 6)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You just need to hit the right cubes";
            }
            if (index == 7)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You need to cut the cubes in the right direction in addition to the correct answer";
            }
            if (index == 8)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You play with two lightsabers";
            }
            if (index == 9)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "You play with one lightsaber";
            }
        }
    }

}
