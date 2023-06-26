using TMPro;
using UnityEngine;
using static LightSaberColorChange;

//This script is used to generate cubes in the game scene based on the settings in the GameModeController.
public class CubeSpawner : MonoBehaviour
{

    public GameObject bluecube;
    public GameObject redcube;

    public GameObject orangecube;
    public GameObject greencube;

    public GameObject purplecube;
    public GameObject yellowcube;


    public GameObject bluecube_noArrow;
    public GameObject redcube_noArrow;

    public GameObject orangecube_noArrow;
    public GameObject greencube_noArrow;

    public GameObject purplecube_noArrow;
    public GameObject yellowcube_noArrow;

    public Transform[] bpoints;
    public Transform[] rpoints;

    public Transform[] onehandcubes;

    public GameObject bluesaber;

    private int[] r = { 0, 2 };

    public GameObject coordinate;

    public SumGenerator sumGenerator;

    public float speed;
    public float distance;
    public Transform disappearPosition;

    void Start()
    {
        distance = disappearPosition.position.z - transform.position.z; 
        speed = GameModeController.settings.generationSpeed;  // set the speed of the cubes based on the settings in the GameModeController.
        if (GameModeController.settings.sabermode == 1) // if the game mode is one hand mode, disable the blue saber.
        {
            bluesaber.SetActive(false);
        }
    }

    //Calculates and returns the spawn time based on the distance and speed variables.
    public float GetSpawnTime()
    {
        float time = -distance / speed;
        return time;
    }

    // Generates cubes based on the game mode and saber mode settings
    public void GenerateCubes(string generatedString)
    {
        if (GameModeController.settings.gamemode == 0)
        {
            if (GameModeController.settings.sabermode == 0)
            {
                GenerateBlueCube_NoArrow();
                GenerateRedCube_NoArrow();
            }
            else if (GameModeController.settings.sabermode == 1)
            {
                GenerateCube_OneHand_NoArrows();
            }

        }
        else if (GameModeController.settings.gamemode == 1)
        {
            if (GameModeController.settings.sabermode == 0)
            {
                GenerateBlueCube();
                GenerateRedCube();
            }
            else if (GameModeController.settings.sabermode == 1)
            {
                GenerateCube_OneHand();
            }
        }

        GameObject coordinate1 = Instantiate(coordinate);
        coordinate1.GetComponent<Cube>().SetMoveSpeed(speed);
    }


    private void GenerateBlueCube_NoArrow()
    {
        GameObject cubePrefab;

        switch (LightSaberColorChange.SelectedLeftHandSaber)
        {
            case LeftHandSaber.blue:
                cubePrefab = bluecube_noArrow;
                break;
            case LeftHandSaber.orange:
                cubePrefab = orangecube_noArrow;
                break;
            case LeftHandSaber.purple:
                cubePrefab = purplecube_noArrow;
                break;
            default:
                return;
        }

        foreach (Transform point in bpoints)
        {
            GameObject cube = Instantiate(cubePrefab, point);
            TextMeshPro number = cube.transform.GetChild(0).GetComponent<TextMeshPro>();
            sumGenerator.answerTexts.Add(number);
            cube.transform.localPosition = Vector3.zero;
            number.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);
            cube.GetComponent<Cube>().SetMoveSpeed(speed);
        }
    }

    private void GenerateRedCube_NoArrow()
    {
        GameObject cubePrefab;

        switch (LightSaberColorChange.SelectedRightHandSaber)
        {
            case RightHandSaber.red:
                cubePrefab = redcube_noArrow;
                break;
            case RightHandSaber.green:
                cubePrefab = greencube_noArrow;
                break;
            case RightHandSaber.yellow:
                cubePrefab = yellowcube_noArrow;
                break;
            default:
                return;
        }

        foreach (Transform point in rpoints)
        {
            GameObject cube = Instantiate(cubePrefab, point);
            TextMeshPro number = cube.transform.GetChild(0).GetComponent<TextMeshPro>();
            sumGenerator.answerTexts.Add(number);
            cube.transform.localPosition = Vector3.zero;
            number.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);
            cube.GetComponent<Cube>().SetMoveSpeed(speed);
        }
    }

    private void GenerateBlueCube()
    {
        GameObject cubePrefab;

        switch (LightSaberColorChange.SelectedLeftHandSaber)
        {
            case LeftHandSaber.blue:
                cubePrefab = bluecube;
                break;
            case LeftHandSaber.orange:
                cubePrefab = orangecube;
                break;
            case LeftHandSaber.purple:
                cubePrefab = purplecube;
                break;
            default:
                return;
        }

        foreach (Transform point in bpoints)
        {
            GameObject cube = Instantiate(cubePrefab, point);
            TextMeshPro number = cube.transform.GetChild(0).GetComponent<TextMeshPro>();
            sumGenerator.answerTexts.Add(number);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * r[Random.Range(0, 2)]);
            number.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);
            cube.GetComponent<Cube>().SetMoveSpeed(speed);
        }
    }

    private void GenerateRedCube()
    {
        GameObject cubePrefab;

        switch (LightSaberColorChange.SelectedRightHandSaber)
        {
            case RightHandSaber.red:
                cubePrefab = redcube;
                break;
            case RightHandSaber.green:
                cubePrefab = greencube;
                break;
            case RightHandSaber.yellow:
                cubePrefab = yellowcube;
                break;
            default:
                return;
        }

        foreach (Transform point in rpoints)
        {
            GameObject cube = Instantiate(cubePrefab, point);
            TextMeshPro number = cube.transform.GetChild(0).GetComponent<TextMeshPro>();
            sumGenerator.answerTexts.Add(number);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * r[Random.Range(0, 2)]);
            number.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);
            cube.GetComponent<Cube>().SetMoveSpeed(speed);
        }
    }

    private void GenerateCube_OneHand_NoArrows()
    {
        GameObject cubePrefab;

        switch (LightSaberColorChange.SelectedRightHandSaber)
        {
            case RightHandSaber.red:
                cubePrefab = redcube_noArrow;
                break;
            case RightHandSaber.green:
                cubePrefab = greencube_noArrow;
                break;
            case RightHandSaber.yellow:
                cubePrefab = yellowcube_noArrow;
                break;
            default:
                return;
        }

        foreach (Transform point in onehandcubes)
        {
            GameObject cube = Instantiate(cubePrefab, point);
            TextMeshPro number = cube.transform.GetChild(0).GetComponent<TextMeshPro>();
            sumGenerator.answerTexts.Add(number);
            cube.transform.localPosition = Vector3.zero;
            number.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);
            cube.GetComponent<Cube>().SetMoveSpeed(speed);
        }
    }

    private void GenerateCube_OneHand()
    {
        GameObject cubePrefab;

        switch (LightSaberColorChange.SelectedRightHandSaber)
        {
            case RightHandSaber.red:
                cubePrefab = redcube;
                break;
            case RightHandSaber.green:
                cubePrefab = greencube;
                break;
            case RightHandSaber.yellow:
                cubePrefab = yellowcube;
                break;
            default:
                return;
        }

        foreach (Transform point in onehandcubes)
        {
            GameObject cube = Instantiate(cubePrefab, point);
            TextMeshPro number = cube.transform.GetChild(0).GetComponent<TextMeshPro>();
            sumGenerator.answerTexts.Add(number);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * r[Random.Range(0, 2)]);
            number.transform.rotation = Quaternion.LookRotation(-transform.forward, transform.up);
            cube.GetComponent<Cube>().SetMoveSpeed(speed);
        }
    }

    //Generate cubes once the sum is generated
    private void OnEnable()
    {
        SumGenerator.GenerateObjectEvent += GenerateCubes;
    }

    private void OnDisable()
    {
        SumGenerator.GenerateObjectEvent -= GenerateCubes;
    }
}
