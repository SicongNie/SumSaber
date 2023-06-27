using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is used to destroy the cubes that exit the game area
public class Uitgang : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other != null)
        {
            Destroy(other.gameObject);
        }
    }
}
