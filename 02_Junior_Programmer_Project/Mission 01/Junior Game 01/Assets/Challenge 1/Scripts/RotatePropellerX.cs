using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
