using CarouselUI;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static LightSaberColorChange;

//This script is responsible for various tasks related to the lightsabers
public class Lightsaber : MonoBehaviour
{
    [SerializeField] public ObjectCut objectCut;   
    public string layer;  // Right saber: Red/ Left saber: Blue
    private bool isTriggered;
    private bool checkangle;

    [SerializeField] SumGenerator sumGenerator;    // UI\Sum Canvas
    private TextMeshPro answer;
    [SerializeField] PlayerScores scores;         // UI\Sum Canvas\Score
    [SerializeField] Numbers counter;             // UI\Sum Canvas\Counter

    private AudioSource cutsound;
    [SerializeField] AudioClip cotsound_hit;        // folder: Assets\Resources\Sounds\right: HitShortRight1.wav or left: HitShortLeft1.wav
    [SerializeField] AudioClip cutsound_faild;      // folder: Assets\Resources\Sounds\right: BadCut0.wav or left: BadCut1.wav
    private bool isPlaying = false;
    [SerializeField] public HapticInteracble hapticInteracble;   // Player\XR Orign\Camera Offset\RightHand/LeftHand Controller
    [SerializeField] GameObject cuteffect;             // folder: Assets\Resources\Prefabs\Spark
    [SerializeField] GameObject warning;           // folder: Assets\Resources\Prefabs\Warning

    private bool hasCollided = false;
    private float cooldownTime = 1f;
    private float cooldownTimer = 0f;

    void Start()
    {
        cutsound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        //when the player cuts the cube with the correct answer
        if (isTriggered)
        {
            if (sumGenerator.canTrigger)
            {
                int a = int.Parse(answer.text);

                scores.GetScores(sumGenerator.CheckAnswer(a));
                counter.questionCount++;
                sumGenerator.canTrigger = false;
            }
            sumGenerator.ShowQuesionAnswer();
            isTriggered = false;
        }

        //make sure the player can't cut more cubes in same time or cut the same cube twice
        if (cooldownTimer > 0f)
        {
            cooldownTimer -= Time.deltaTime;
        }

        if (cooldownTimer <= 0f && hasCollided)
        {
            hasCollided = false;
        }

    }

    //when the lightsabers collide with the cube
    private void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && cooldownTimer <= 0f)
        {
            //if the game mode is With Arrows
            if (GameModeController.settings.gamemode == 1)
            {
                //check if the lightsabers are in the correct angle
                if (Vector3.Angle(objectCut._blade.transform.position - objectCut.previousPos, other.transform.up) > 100 || Vector3.Angle(objectCut._blade.transform.position - objectCut.previousPos, other.transform.up) == 0)
                {
                    CutContinue();
                }
                else // if not, show a error message
                {
                    GameObject objectwarning = Instantiate(warning, other.transform.GetChild(0).GetChild(0).position, Quaternion.identity);
                    objectwarning.GetComponent<TextMeshPro>().text = "Miss";
                    Destroy(objectwarning, 1f);
                    hapticInteracble.TriggerHaptic();
                    PlayCutSound_Faild();
                }
            }
            else // if the game mode is Without Arrows, check angle is not needed
            {
                CutContinue();
            }
            objectCut.GetPositions();
        }
        cooldownTimer = cooldownTime; 
        hasCollided = true;

    }

    //when the lightsabers exit the cube
    private void OnTriggerExit(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (checkangle)
        {
            //check if the sabers match the color of the cube
            if (layerName == layer)
            {
                isTriggered = true;
            }
            else // if not, show a error message
            {
                isTriggered = false;
                GameObject objectwarning = Instantiate(warning, other.transform.GetChild(0).GetChild(0).position, Quaternion.identity);
                if (CarouselUIElement._currentIndex == 0)
                {
                    objectwarning.GetComponent<TextMeshPro>().text = "Foute Kleur";
                }
                else if (CarouselUIElement._currentIndex == 1)
                {
                    objectwarning.GetComponent<TextMeshPro>().text = "Wrong Color";
                }

                Destroy(objectwarning, 1f);
            }
            objectCut.CutObject(other);
            answer = other.transform.GetChild(0).GetComponent<TextMeshPro>();

            GameObject objecteffect = Instantiate(cuteffect, other.transform.position, Quaternion.identity); // generate sparking effect
            objecteffect.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
            Destroy(objecteffect, 2f);
            checkangle = false;
        }
    }

    private void CutContinue()
    {
        hapticInteracble.TriggerHaptic();
        PlayCutSound();
        checkangle = true;
    }

    private void PlayCutSound()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            cutsound.clip = cotsound_hit;
            cutsound.Play();
            StartCoroutine(WaitForSoundEnd(cutsound_faild.length));
        }
    }

    private void PlayCutSound_Faild()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            cutsound.clip = cutsound_faild;
            cutsound.Play();
            StartCoroutine(WaitForSoundEnd(cutsound_faild.length));
        }
    }

    // wait for the sound to end before playing it again
    private IEnumerator WaitForSoundEnd(float clipLength)
    {
        yield return new WaitForSeconds(clipLength);
        isPlaying = false;
    }

}
