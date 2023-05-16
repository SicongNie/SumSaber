using System.Collections;
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
        if (GameModeController.settings.gamemode == 1)
        {
            if (Vector3.Angle(objectCut._blade.transform.position - objectCut.previousPos, other.transform.up) > 100)
            {
                CutContinue();
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
            CutContinue();
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
                objectwarning.GetComponent<TextMeshPro>().text = "Wrong Color";
                Destroy(objectwarning, 1f);
            }
            objectCut.CutObject(other);
            answer = other.transform.GetChild(0).GetComponent<TextMeshPro>();
            GameObject objecteffect = Instantiate(effect, other.transform.position, Quaternion.identity);
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

    private IEnumerator WaitForSoundEnd(float clipLength)
    {
        yield return new WaitForSeconds(clipLength);
        isPlaying = false;
    }

}
