using Assets.Scripts.CubeCut;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class Lightsaber : MonoBehaviour
{
    public string layer;
    private bool isTriggered;
    [SerializeField] SumGenerator sumGenerator;
    private TextMeshPro answer;
    [SerializeField] PlayerScores scores;
    [SerializeField] Numbers counter;
    private bool checkangle;

    private AudioSource cutsound;
    [SerializeField] AudioClip cotsound_hit;
    [SerializeField] AudioClip cutsound_faild;
    private bool isPlaying = false;

    public HapticInteracble hapticInteracble;

    public GameObject effect;
    [SerializeField] GameObject warning;

    public ObjectCut objectCut;

    void Start()
    {
        cutsound = GetComponent<AudioSource>();
    }

    private void Update()
    {
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
    }

    private void OnTriggerEnter(Collider other)
    {
        /*        if (layerName == layer)
                {
                    if(GameModeController.settings.gamemode == 1)
                    {
                        if (Vector3.Angle(objectCut._blade.transform.position - objectCut.previousPos, other.transform.up) > 130)
                        {
                            hapticInteracble.TriggerHaptic();
                            PlayCutSound();
                            checkangle = true;
                        }
                        else
                        {
                            hapticInteracble.TriggerHaptic();
                            PlayCutSound_Faild();
                        }
                    }
                    else
                    {
                        hapticInteracble.TriggerHaptic();
                        PlayCutSound();
                        checkangle = true;
                    }


                }*/
        if (GameModeController.settings.gamemode == 1)
        {
            if (Vector3.Angle(objectCut._blade.transform.position - objectCut.previousPos, other.transform.up) > 130)
            {
                hapticInteracble.TriggerHaptic();
                PlayCutSound();
                checkangle = true;
            }
            else
            {
                GameObject objectwarning = Instantiate(warning, other.transform.GetChild(0).GetChild(0).position, Quaternion.identity);
                objectwarning.GetComponent<TextMeshPro>().text = "Miss";
                hapticInteracble.TriggerHaptic();
                PlayCutSound_Faild();
            }
        }
        else
        {
            hapticInteracble.TriggerHaptic();
            PlayCutSound();
            checkangle = true;
        }



        objectCut.GetPositions();
    }

    private void OnTriggerExit(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (checkangle)
        {
            if (layerName == layer)
            {
                isTriggered = true;
            }
            else
            {
                isTriggered= false;
                GameObject objectwarning = Instantiate(warning, other.transform.GetChild(0).GetChild(0).position, Quaternion.identity);
                objectwarning.GetComponent<TextMeshPro>().text = "X";
                Destroy(objectwarning, 1f);
            }
            objectCut.CutObject(other);
            answer = other.transform.GetChild(0).GetComponent<TextMeshPro>();
            GameObject objecteffect = Instantiate(effect, other.transform.position, Quaternion.identity);
            Destroy(objecteffect, 2f);
            checkangle = false;
        }
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

    private IEnumerator WaitForSoundEnd(float clipLength)
    {
        yield return new WaitForSeconds(clipLength);
        isPlaying = false;
    }

}
