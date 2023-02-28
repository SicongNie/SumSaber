using EzySlice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class Lighsaber : MonoBehaviour
{
    private Vector3 previousPos;

    void Start()
    {

    }
    
    
    void Update()
    {
       /* 
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward, out hit, 1, layer)){
            if(Vector3.Angle(transform.position-previousPos, hit.transform.up)>130){
                Destroy(hit.transform.gameObject);
            }
        }
       */
        previousPos = transform.position;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (Vector3.Angle(transform.position - previousPos, other.transform.up) > 130)
        {
            Destroy(other.transform.gameObject);
        }
    }
}
