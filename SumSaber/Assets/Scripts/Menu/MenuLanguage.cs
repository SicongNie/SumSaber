using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CarouselUI;
using TMPro;

public class MenuLanguage : MonoBehaviour
{

    public void ShowText(int index)
    {
        if (CarouselUIElement._currentIndex == 0)
        {
            if (index == 0)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "Nederlands";
            }
        }
        else if (CarouselUIElement._currentIndex == 1)
        {
            if (index == 0)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = "English";
            }
        }
    }

}
