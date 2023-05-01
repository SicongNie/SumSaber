using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;


public class CubeSpawner : MonoBehaviour
{

    public GameObject bluecube;
    public GameObject redcube;

    public GameObject bluecube_noArrow;
    public GameObject redcube_noArrow;

    TextMeshPro bnumber;
    TextMeshPro rnumber;

    public Transform[] bpoints;
    public Transform[] rpoints;

    public Transform[] onehandcubes;
    public GameObject bluesaber;



    /*    public GameObject[] cubes;
        public Transform[] points;
        TextMeshPro number;
    */

    private int[] r = { 0, 2 };

    public GameObject coordinate;

    public SumGenerator sumGenerator;

    public float speed;
    public float distance;
    public Transform disappearPosition;

    void Start()
    {
        distance = disappearPosition.position.z - transform.position.z;
        speed = GameModeController.settings.generationSpeed;
        if(GameModeController.settings.gamemode == 2)
        {
            bluesaber.SetActive(false);
        }
    }

    void Update()
    {

    }


    public float GetSpawnTime()
    {
        float time = -distance / speed;
        return time;
    }

    public void GenerateCubes(string generatedString)
    {
        if (GameModeController.settings.gamemode == 0)
        {
            foreach (Transform point in bpoints)
            {
                GameObject bcube = Instantiate(bluecube_noArrow, point);
                bnumber = bcube.transform.GetChild(0).GetComponent<TextMeshPro>();
                sumGenerator.answerTexts.Add(bnumber);

                bcube.transform.localPosition = Vector3.zero;
                bnumber.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);

                bcube.GetComponent<Cube>().SetMoveSpeed(speed);
            }

            foreach (Transform point in rpoints)
            {
                GameObject rcube = Instantiate(redcube_noArrow, point);
                rnumber = rcube.transform.GetChild(0).GetComponent<TextMeshPro>();
                sumGenerator.answerTexts.Add(rnumber);

                rcube.transform.localPosition = Vector3.zero;
                rnumber.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);

                rcube.GetComponent<Cube>().SetMoveSpeed(speed);
            }
        }
        else if (GameModeController.settings.gamemode == 1)
        {
            foreach (Transform point in bpoints)
            {
                GameObject bcube = Instantiate(bluecube, point);
                bnumber = bcube.transform.GetChild(0).GetComponent<TextMeshPro>();
                sumGenerator.answerTexts.Add(bnumber);

                bcube.transform.localPosition = Vector3.zero;
                bcube.transform.Rotate(transform.forward, 90 * r[Random.Range(0, 2)]);
                bnumber.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);

                bcube.GetComponent<Cube>().SetMoveSpeed(speed);
            }

            foreach (Transform point in rpoints)
            {
                GameObject rcube = Instantiate(redcube, point);
                rnumber = rcube.transform.GetChild(0).GetComponent<TextMeshPro>();
                sumGenerator.answerTexts.Add(rnumber);

                rcube.transform.localPosition = Vector3.zero;
                rcube.transform.Rotate(transform.forward, 90 * r[Random.Range(0, 2)]);
                rnumber.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);

                rcube.GetComponent<Cube>().SetMoveSpeed(speed);
            }
        }
        else if (GameModeController.settings.gamemode == 2)
        {
            foreach (Transform point in onehandcubes)
            {
                GameObject rcube = Instantiate(redcube_noArrow, point);
                rnumber = rcube.transform.GetChild(0).GetComponent<TextMeshPro>();
                sumGenerator.answerTexts.Add(rnumber);

                rcube.transform.localPosition = Vector3.zero;
                rnumber.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);

                rcube.GetComponent<Cube>().SetMoveSpeed(speed);
            }
        }


        /*        foreach(Transform point in points)
                {
                    GameObject cube = Instantiate(cubes[Random.Range(0,2)], point);
                    number = cube.transform.GetChild(0).GetComponent<TextMeshPro>();
                    sumGenerator.answerTexts.Add(number);

                    cube.transform.localPosition = Vector3.zero;
                    cube.transform.Rotate(transform.forward, 90 * r[Random.Range(0, 2)]);
                    number.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);

                    cube.GetComponent<Cube>().SetMoveSpeed(speed);
                }
        */

        GameObject coordinate1 = Instantiate(coordinate);
        coordinate1.GetComponent<Cube>().SetMoveSpeed(speed);
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
