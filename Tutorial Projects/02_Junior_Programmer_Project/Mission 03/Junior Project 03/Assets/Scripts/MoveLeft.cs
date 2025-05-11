using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    private PlayerController playerControllerScript;
    public float leftBound = -15.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            if (playerControllerScript.doubleSpeed)
            {
                transform.Translate(Vector3.left * (speed * 2) * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
