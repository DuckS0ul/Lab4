using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AsteroidRotation : MonoBehaviour
{
    public float rotationSpeed = 10f;

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Set rotation along the Y axis
            rb.angularVelocity = new Vector3(0, rotationSpeed, 0);
        }
        else
        {
            Debug.LogError("No Rigidbody component found on " + gameObject.name);
        }
    }
}