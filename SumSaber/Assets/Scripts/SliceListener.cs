using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.InputSystem.HID;

public class SliceListener : MonoBehaviour
{
    private Vector3 previousPos;
    public Slicer slicer;
    private bool test;


    void Start()
    {

    }

    private void Update()
    {
        previousPos = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Vector3.Angle(transform.position - previousPos, other.transform.up) > 130)
        {
            slicer.isTouched = true;
        }
    }
}
