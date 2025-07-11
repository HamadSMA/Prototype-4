using UnityEngine;
using UnityEngine.Rendering;

public class SpawnManager : MonoBehaviour
{
    // Start is called once bef
    // publicore the first execution of Update after the MonoBehaviour is created
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;
    void Start()
    {
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;
        if (enemyCount == 0)
        {
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);

            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), transform.rotation);

        }
    }


    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange + 1);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange + 1);

        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return spawnPos;
    }
}
