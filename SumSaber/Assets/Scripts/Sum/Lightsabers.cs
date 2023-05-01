using EzySlice;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class Lightsabers: MonoBehaviour
{
    public string layer;
    private Vector3 previousPos;

    private bool isTriggered;
    [SerializeField] SumGenerator sumGenerator;
    private TextMeshPro answer;

    [SerializeField] PlayerScores scores;
    [SerializeField] Numbers counter;

    void Start()
    {

    }


    void Update()
    {
        /*        RaycastHit hit;
                if(Physics.Raycast(transform.position, transform.forward, out hit,1, layer))
                {
                    if(Vector3.Angle(transform.position- previousPos,hit.transform.up) > 130)
                    {
                        Destroy(hit.transform.gameObject);
                    }
                }
                previousPos = transform.position;
        */

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
            isTriggered= false;
        }
        previousPos = transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (layerName == layer)
        {
            if (Vector3.Angle(transform.position - previousPos, other.transform.up) > 130)
            {
                isTriggered= true;
                answer = other.transform.GetChild(1).GetComponent<TextMeshPro>();
                Destroy(other.transform.gameObject);
            }
        }
    }


    private void LateUpdate()
    {
        previousPos = transform.position;
    }



}
