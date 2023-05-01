using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliceListener : MonoBehaviour
{
    private Vector3 previousPos;
    public Slicer slicer;

    public string layer;

    private bool isTriggered;
    [SerializeField] SumGenerator sumGenerator;
    private TextMeshPro answer;

    [SerializeField] PlayerScores scores;
    [SerializeField] Numbers counter;

    void Start()
    {

    }

    private void Update()
    {
        if (isTriggered)
        {
            int a = int.Parse(answer.text);

            if (sumGenerator.CheckAnswer(a))
            {
                Debug.Log("correct");
            }
            else
            {
                Debug.Log("incorrect");
            }
            scores.GetScores(sumGenerator.CheckAnswer(a));
            counter.questionCount++;
            sumGenerator.ShowQuesionAnswer();
            isTriggered = false;
        }
        previousPos = transform.position;
        previousPos = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (layerName == layer)
        {
            if (Vector3.Angle(transform.position - previousPos, other.transform.up) > 130)
            {
                isTriggered = true;
                answer = other.transform.GetChild(1).GetComponent<TextMeshPro>();
                slicer.isTouched = true;
            }
        }
    }

    private void LateUpdate()
    {
        previousPos = transform.position;
    }
}
