using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float startDelay = 2.0f;
    public float spawnInterval = 3.5f;
    private PlayerController playerControllerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            int index = Random.Range(0, obstaclePrefabs.Length);
            Vector3 spawnPos = new Vector3(25, 0, 0);
            Instantiate(obstaclePrefabs[index], spawnPos, obstaclePrefabs[index].transform.rotation);
        }
    }
}
