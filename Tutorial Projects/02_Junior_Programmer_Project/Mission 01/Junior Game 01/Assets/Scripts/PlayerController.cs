using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedOfPlayer = 15.0f;
    [SerializeField] private float turnSpeedOfPlayer = 45.0f;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKeyCode;
    public string inputID;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move forward and backward
        float verticalInput = Input.GetAxis("Vertical" + inputID);
        transform.Translate(Vector3.forward * verticalInput * speedOfPlayer * Time.deltaTime);

        // move left and right
        float horizontalInput = Input.GetAxis("Horizontal" + inputID);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeedOfPlayer * Time.deltaTime);

        // switch between mainCamera and hoodCamera
        if (Input.GetKeyDown(switchKeyCode))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
