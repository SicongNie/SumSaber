using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This script is used to control the error message on the positons of the cubes when the player gets a question wrong or slices the wrong cubes
public class Warning : MonoBehaviour
{
    private float fadeDuration = 1f;
    private TextMeshPro textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
        StartCoroutine(FadeOut());
    }

    // message move forward
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 1;
    }

    // message fade out
    private IEnumerator FadeOut()
    {
        Color startColor = textMesh.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 0f);

        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            textMesh.color = Color.Lerp(startColor, endColor, t / fadeDuration);
            yield return null;
        }
    }

}
