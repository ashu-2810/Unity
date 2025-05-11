using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefab;
    private float spawnRangeX = 12.0f;
    private float spawnPosZ = 20.0f;
    private float startDelay = 2.0f;
    private float spawnIntervals = 1.5f;

    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnIntervals);
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnIntervals);
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnIntervals);
    }

    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    // Update is called once per frame
    void SpawnRandomAnimal()
    {
        int index = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefab[index], spawnPos, animalPrefab[index].transform.rotation);
    }
}
