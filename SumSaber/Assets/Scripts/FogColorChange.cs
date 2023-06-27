using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script controls the transition of fog color of the backgrond and density based on the progress of the questions
public class FogColorChange : MonoBehaviour
{
    [SerializeField] public Color targetColor;            // #FFA145
    [SerializeField] public Color targetColor2;           // #3E454B
    [SerializeField] public float targetDensity;        // 0.04
    [SerializeField] public float transitionTime;          // 1.5 
    private float transitionTimer2;

    private Color initialColor;
    private float initialDensity;
    private float transitionTimer;

    [SerializeField] Numbers counter;                //  UI\ Sum Canvas\Counter

    private void Start()
    {
        initialColor = RenderSettings.fogColor;
        initialDensity = RenderSettings.fogDensity;
    }

    private void Update()
    {
        int c = counter.maxQuestionCount / 3;
        //when the question count is 1/3 of the max question count, the fog color will change to the target color.
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
        //when the question count is 2/3 of the max question count, the fog color will change to the target color2.
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
