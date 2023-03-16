using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class CubeSpawner : MonoBehaviour
{
    public GameObject bluecube;
    public GameObject redcube;

    TextMeshPro bnumber;
    TextMeshPro rnumber;

    public Transform[] bpoints;
    public Transform[] rpoints;
    private int[] r = { 0, 2 };

    public SumGenerator sumGenerator;

    // public float beat;
    // private float timer;


    void Start()
    {

    }

    void Update()
    {
        /* if (timer > beat)
         {

             timer -= beat;
         }
         timer += Time.deltaTime;
        */
    }

    public void GenerateCubes(string generatedString)
    {
        foreach (Transform point in bpoints)
        {
            GameObject bcube = Instantiate(bluecube, point);
            bnumber = bcube.transform.GetChild(0).GetComponent<TextMeshPro>();
            sumGenerator.answerTexts.Add(bnumber);

            bcube.transform.localPosition = Vector3.zero;
            bcube.transform.Rotate(transform.forward, 90 * r[Random.Range(0, 2)]);
            bnumber.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);
            Destroy(bcube, 10);
        }

        foreach (Transform point in rpoints)
        {
            GameObject rcube = Instantiate(redcube, point);
            rnumber = rcube.transform.GetChild(0).GetComponent<TextMeshPro>();
            sumGenerator.answerTexts.Add(rnumber);

            rcube.transform.localPosition = Vector3.zero;
            rcube.transform.Rotate(transform.forward, 90 * r[Random.Range(0, 2)]);
            rnumber.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);
            Destroy(rcube, 10);
        }
    }

    private void OnEnable()
    {
        SumGenerator.GenerateObjectEvent += GenerateCubes;
    }

    private void OnDisable()
    {
        SumGenerator.GenerateObjectEvent -= GenerateCubes;
    }
}
