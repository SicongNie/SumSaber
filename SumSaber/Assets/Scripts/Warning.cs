using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Warning : MonoBehaviour
{
    private float fadeDuration = 1f;
    private TextMeshPro textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
        StartCoroutine(FadeOut());

    }

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 1;
    }
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
