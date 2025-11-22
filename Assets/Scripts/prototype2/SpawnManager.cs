using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalsPrefabs;
    [SerializeField] private float xRangePos = 10f;
    [SerializeField] private float zPos = 20f;
    [SerializeField] private float startTimeToSpawn = 2f;
    [SerializeField] private float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startTimeToSpawn, spawnInterval);
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Vector3 pos = new Vector3(Random.Range(-xRangePos, xRangePos), 0, zPos);
        Instantiate(animalsPrefabs[animalIndex], pos, animalsPrefabs[animalIndex].transform.rotation);
    }
}
