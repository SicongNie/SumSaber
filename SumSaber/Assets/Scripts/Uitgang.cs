using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
