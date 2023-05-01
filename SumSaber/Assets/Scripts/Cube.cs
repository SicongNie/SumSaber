using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float moveSpeed;

    void Start()
    {

    }
   public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * moveSpeed;
    }

}
