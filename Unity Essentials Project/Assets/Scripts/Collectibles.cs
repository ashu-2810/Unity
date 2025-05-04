using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 0.5f;
    public GameObject onCollisionEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            Instantiate(onCollisionEffect, transform.position, transform.rotation);
        }

    }
}
