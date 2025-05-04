using UnityEngine;

public class DayNightChanger : MonoBehaviour
{
    [Tooltip("The duration of a full day in seconds.")]
    public float dayDurationInSeconds = 120f;

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed for a full 360-degree rotation based on the day duration.
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate the light around the x-axis to simulate the day-night cycle.
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}


// 02-05-2025 AI-Tag
// This was created with assistance from Muse, a Unity Artificial Intelligence product
