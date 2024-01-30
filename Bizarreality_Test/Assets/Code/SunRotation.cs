using System;
using UnityEngine;

public class SunRotation : MonoBehaviour
{
    void Update()
    {
        // Get the current time in hours
        float currentTime = DateTime.Now.Hour;

        // Map the time to a rotation angle (adjust the range as needed)
        float angle = Mathf.Lerp(-90f, 90f, currentTime / 24f);

        // Set the rotation of the directional light
        transform.rotation = Quaternion.Euler(angle, 180f, 0f);
    }
}