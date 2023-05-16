using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogColorChange : MonoBehaviour
{
    public Color targetColor;
    public Color targetColor2;
    public float targetDensity;
    public float transitionTime;
    private float transitionTimer2;

    private Color initialColor;
    private float initialDensity;
    private float transitionTimer;

    [SerializeField] Numbers counter;

    private void Start()
    {
        initialColor = RenderSettings.fogColor;
        initialDensity = RenderSettings.fogDensity;
    }

    private void Update()
    {
        int c = counter.maxQuestionCount / 3;
        if (counter.questionCount == c)
        {
            transitionTimer += Time.deltaTime;
            if (transitionTimer < transitionTime)
            {
                float t = transitionTimer / transitionTime;
                RenderSettings.fogColor = Color.Lerp(initialColor, targetColor, t);
                RenderSettings.fogDensity = Mathf.Lerp(initialDensity, targetDensity, t);
            }
            else
            {
                RenderSettings.fogColor = targetColor;
                RenderSettings.fogDensity = targetDensity;
            }
          
        }
        if (counter.questionCount == c * 2)
        {
            transitionTimer2 += Time.deltaTime;
            if (transitionTimer2 < transitionTime)
            {
                float t = transitionTimer2 / transitionTime;
                RenderSettings.fogColor = Color.Lerp(targetColor, targetColor2, t);
                RenderSettings.fogDensity = Mathf.Lerp(initialDensity, targetDensity, t);
            }
            else
            {
                RenderSettings.fogColor = targetColor2;
                RenderSettings.fogDensity = targetDensity;
            }
        }
    }
}
