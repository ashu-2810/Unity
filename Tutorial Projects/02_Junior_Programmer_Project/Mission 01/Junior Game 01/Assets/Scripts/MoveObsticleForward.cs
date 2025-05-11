using UnityEngine;

public class MoveObsticleForward : MonoBehaviour
{
    [SerializeField] private float forwardMovingSpeed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * forwardMovingSpeed * Time.deltaTime);
    }
}
