using UnityEngine;
using UnityEngine.Rendering;

public class SpawnManager : MonoBehaviour
{
    // Start is called once bef
    // publicore the first execution of Update after the MonoBehaviour is created
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    void Start()
    {


        Instantiate(enemyPrefab, GenerateSpawnPosition(), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange + 1);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange + 1);

        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return spawnPos;
    }
}
