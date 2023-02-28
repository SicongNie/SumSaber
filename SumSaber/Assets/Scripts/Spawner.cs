using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class Spawner : MonoBehaviour
{
    //public GameObject[] cubes;
    public GameObject bluecube;
    public GameObject redcube;


    public Transform[] bpoints;
    public Transform[] rpoints;
    public float beat;
    private float timer;

    void Start()
    {

    }

    void Update()
    {
        if (timer > beat)
        {
            // GameObject cube =  Instantiate(cubes[Random.Range(0,2)], points[Random.Range(0,4)]);
            //cube.transform.localPosition = Vector3.zero;
            // cube.transform.Rotate(transform.forward, 90* Random.Range(0,4));
            GameObject bcube = Instantiate(bluecube, bpoints[Random.Range(0, 2)]);
            GameObject rcube = Instantiate(redcube, rpoints[Random.Range(0, 2)]);
            bcube.transform.localPosition = Vector3.zero;
            bcube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            rcube.transform.localPosition = Vector3.zero;
            rcube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));

            timer -= beat;
            Destroy(bcube, 10);
            Destroy(rcube, 10);
        }
        timer += Time.deltaTime;
    }
}
