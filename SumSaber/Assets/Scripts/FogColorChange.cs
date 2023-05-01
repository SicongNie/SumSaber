using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogColorChange : MonoBehaviour
{
    public Color targetColor; 
    public float targetDensity; 
    public float transitionTime; 

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
        if (counter.questionCount == 6)
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
    }

}
