using CarouselUI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This script manages the dynamic scroll view in the results menu
public class DynamicScrollView : MonoBehaviour
{
    public RectTransform content;
    public GameObject listItemPrefab;

    [SerializeField] TextMeshProUGUI sumsTxt;

    public void ShowResult()
    {
        // Clear existing list item Prefabs.
        foreach (Transform child in content.transform)
        {
            Destroy(child.gameObject);
        }
        List<string> wrongAnswers = SumGenerator.wrongAnswers;
        if (wrongAnswers.Count > 0)
        {
            // Create list items for each wrong answer.
            foreach (string answer in wrongAnswers)
            {
                CreateListItem(answer);
                UpdateContentHeight();
            }          
        }
        else
        {
            // Display appropriate result message based on the current carousel index.
            if (CarouselUIElement._currentIndex == 0)
            {
                sumsTxt.text = "Je hebt alle sommen goed gemaakt!";
            }
            else if (CarouselUIElement._currentIndex == 1)
            {
                sumsTxt.text = "You did all the sums right!";
            }
        }
    }


    private void CreateListItem(string item)
    {
        GameObject listItem = Instantiate(listItemPrefab, content);
        TextMeshProUGUI textComponent = listItem.GetComponentInChildren<TextMeshProUGUI>();
        textComponent.text = item;
        textComponent.enabled = true;
    }

    // Updates the height of the content based on the number of list items.
    private void UpdateContentHeight()
    {
        int itemCount = SumGenerator.wrongAnswers.Count;
        float itemHeight = listItemPrefab.GetComponent<RectTransform>().rect.height;
        float contentHeight = itemCount * itemHeight;

        content.sizeDelta = new Vector2(content.sizeDelta.x, contentHeight);
    }

}
