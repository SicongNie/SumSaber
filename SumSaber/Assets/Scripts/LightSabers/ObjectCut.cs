using Assets.Scripts.CubeCut;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// This script contains the logic for cutting the cubes
public class ObjectCut : MonoBehaviour
{
    private const int NUM_VERTICES = 12;

    [SerializeField]
    [Tooltip("The blade object")]
    public GameObject _blade;   // Parent\Blade

    [SerializeField]
    [Tooltip("The empty game object located at the tip of the blade")]
    private GameObject _tip;   // Parent\Blade\Tip

    [SerializeField]
    [Tooltip("The empty game object located at the base of the blade")]
    private GameObject _base;  // Parent\Blade\Base

    [SerializeField]
    [Tooltip("The mesh object with the mesh filter and mesh renderer")]
    private GameObject _meshParent;    //Parent\TrailMesh

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

    // private Vector3 _previousParentPosition;

    private Vector3 _triggerEnterTipPosition;
    private Vector3 _triggerEnterBasePosition;
    private Vector3 _triggerExitTipPosition;
    public Vector3 previousPos;


    private void Start()
    {
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
    }

    private void Update()
    {
        previousPos = _blade.transform.position;
    }

    void LateUpdate()
    {
        previousPos = _blade.transform.position;
        //Reset the frame count one we reach the frame length
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

    public void GetPositions()
    {
        _triggerEnterTipPosition = _tip.transform.position;
        _triggerEnterBasePosition = _base.transform.position;
    }

    public void CutObject(Collider other)
    {

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

    }

}
