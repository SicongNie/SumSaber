using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used to set the speed of the cubes in the game scene.
public class Cube : MonoBehaviour
{
    private float moveSpeed;

   public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * moveSpeed;
    }

}
