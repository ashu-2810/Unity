using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    // variables
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float sideBound = 30.0f;
    private GameManager gameManager;
    // start
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // update
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}