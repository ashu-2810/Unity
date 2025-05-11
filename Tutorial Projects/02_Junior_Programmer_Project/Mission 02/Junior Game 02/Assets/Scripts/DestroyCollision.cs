using UnityEngine;

public class DestroyCollision : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Debug.Log("gameOver!!!");
            gameManager.AddLives(-1);
            Destroy(gameObject);

        }
        else if(other.CompareTag("Animal"))
        {
            // gameManager.AddScore(5);
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            // Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
