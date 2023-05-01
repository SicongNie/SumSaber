using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.CubeCut;
using TMPro;
using UnityEngine;

public class BackUpLightsaber : MonoBehaviour
{
/*    private const int NUM_VERTICES = 12;

    [SerializeField]
    [Tooltip("The blade object")]
    private GameObject _blade;

    [SerializeField]
    [Tooltip("The empty game object located at the tip of the blade")]
    private GameObject _tip;

    [SerializeField]
    [Tooltip("The empty game object located at the base of the blade")]
    private GameObject _base;

    [SerializeField]
    [Tooltip("The mesh object with the mesh filter and mesh renderer")]
    private GameObject _meshParent;

    [SerializeField]
    [Tooltip("The number of frame that the trail should be rendered for")]
    private int _trailFrameLength = 3;

    [SerializeField]
    [ColorUsage(true, true)]
    [Tooltip("The colour of the blade and trail")]
    private Color _colour = Color.red;

    [SerializeField]
    [Tooltip("The amount of force applied to each side of a slice")]
    private float _forceAppliedToCut = 3f;

    private Mesh _mesh;
    private Vector3[] _vertices;
    private int[] _triangles;
    private int _frameCount;
    private Vector3 _previousTipPosition;
    private Vector3 _previousBasePosition;
    private Vector3 previousPos;

    // private Vector3 _previousParentPosition;

     private Vector3 _triggerEnterTipPosition;
    private Vector3 _triggerEnterBasePosition;
    private Vector3 _triggerExitTipPosition;

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

    public ObjectCut objectCut;

    void Start()
    {
        // _meshParent.transform.position = Vector3.zero;
        //  _mesh = new Mesh();
        //  _meshParent.GetComponent<MeshFilter>().mesh = _mesh;

        Material trailMaterial = Instantiate(_meshParent.GetComponent<MeshRenderer>().sharedMaterial);
        trailMaterial.SetColor("Color_8F0C0815", _colour);
        _meshParent.GetComponent<MeshRenderer>().sharedMaterial = trailMaterial;

        Material bladeMaterial = Instantiate(_blade.GetComponent<MeshRenderer>().sharedMaterial);
        bladeMaterial.SetColor("Color_AF2E1BB", _colour);
        _blade.GetComponent<MeshRenderer>().sharedMaterial = bladeMaterial;

        _vertices = new Vector3[_trailFrameLength * NUM_VERTICES];
        _triangles = new int[_vertices.Length];

        _previousTipPosition = _tip.transform.position;
        _previousBasePosition = _base.transform.position;

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

    void LateUpdate()
    {
        previousPos = _blade.transform.position;

        if (_frameCount == (_trailFrameLength * NUM_VERTICES))
        {
            _frameCount = 0;
        }

        _vertices[_frameCount] = _base.transform.position;
        _vertices[_frameCount + 1] = _tip.transform.position;
        _vertices[_frameCount + 2] = _previousTipPosition;
        _vertices[_frameCount + 3] = _base.transform.position;
        _vertices[_frameCount + 4] = _previousTipPosition;
        _vertices[_frameCount + 5] = _tip.transform.position;

        _vertices[_frameCount + 6] = _previousTipPosition;
        _vertices[_frameCount + 7] = _base.transform.position;
        _vertices[_frameCount + 8] = _previousBasePosition;
        _vertices[_frameCount + 9] = _previousTipPosition;
        _vertices[_frameCount + 10] = _previousBasePosition;
        _vertices[_frameCount + 11] = _base.transform.position;

        _triangles[_frameCount] = _frameCount;
        _triangles[_frameCount + 1] = _frameCount + 1;
        _triangles[_frameCount + 2] = _frameCount + 2;
        _triangles[_frameCount + 3] = _frameCount + 3;
        _triangles[_frameCount + 4] = _frameCount + 4;
        _triangles[_frameCount + 5] = _frameCount + 5;
        _triangles[_frameCount + 6] = _frameCount + 6;
        _triangles[_frameCount + 7] = _frameCount + 7;
        _triangles[_frameCount + 8] = _frameCount + 8;
        _triangles[_frameCount + 9] = _frameCount + 9;
        _triangles[_frameCount + 10] = _frameCount + 10;
        _triangles[_frameCount + 11] = _frameCount + 11;

        //  _mesh.vertices = _vertices;
        // _mesh.triangles = _triangles;

        _previousTipPosition = _tip.transform.position;
        _previousBasePosition = _base.transform.position;
        _frameCount += NUM_VERTICES;
    }

    private void OnTriggerEnter(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (layerName == layer)
        {
            if (Vector3.Angle(_blade.transform.position - previousPos, other.transform.up) > 130)
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

        _triggerEnterTipPosition = _tip.transform.position;
        _triggerEnterBasePosition = _base.transform.position;

    }

    private void OnTriggerExit(Collider other)
    {
        if (checkangle)
        {
            isTriggered = true;
            answer = other.transform.GetChild(0).GetComponent<TextMeshPro>();

            _triggerExitTipPosition = _tip.transform.position;

            Vector3 side1 = _triggerExitTipPosition - _triggerEnterTipPosition;
            Vector3 side2 = _triggerExitTipPosition - _triggerEnterBasePosition;

            Vector3 normal = Vector3.Cross(side1, side2).normalized;

            Vector3 transformedNormal = ((Vector3)(other.gameObject.transform.localToWorldMatrix.transpose * normal)).normalized;

            Vector3 transformedStartingPoint = other.gameObject.transform.InverseTransformPoint(_triggerEnterTipPosition);

            Plane plane = new Plane();

            plane.SetNormalAndPosition(
                    transformedNormal,
                    transformedStartingPoint);

            var direction = Vector3.Dot(Vector3.up, transformedNormal);

            if (direction < 0)
            {
                plane = plane.flipped;
            }

            GameObject[] slices = Slicer1.Slice(plane, other.gameObject);
            GameObject objecteffect = Instantiate(effect, other.transform.position, Quaternion.identity);
            Destroy(objecteffect, 2f);

            Destroy(other.gameObject);
            Rigidbody rigidbody = slices[1].GetComponent<Rigidbody>();

            Rigidbody rigidbody2 = slices[0].GetComponent<Rigidbody>();
            //  Vector3 newNormal = transformedNormal + Vector3.up * _forceAppliedToCut;
            //  rigidbody.AddForce(newNormal, ForceMode.Impulse);

            Vector3 newNormal = transformedNormal + Vector3.right * _forceAppliedToCut;
            rigidbody.AddForce(newNormal * 1f, ForceMode.Impulse);
            rigidbody2.AddForce(-newNormal * 1f, ForceMode.Impulse);


            foreach (GameObject slicedObject in slices)
            {
                Destroy(slicedObject, 2f);
            }
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
    }*/

}
