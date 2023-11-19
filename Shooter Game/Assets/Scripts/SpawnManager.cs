using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    private float spawnRangeX = 4;
    

    [SerializeField] private float obstacleSpawnDistance;
    [SerializeField] private float startZPosition;
    [SerializeField] private float endZPosition;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomObstacle();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomObstacle()
    {
        int obstacleSpawnCount = Mathf.FloorToInt((endZPosition - startZPosition) / obstacleSpawnDistance);

        for (int i = 1; i <= obstacleSpawnCount; i++){

        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, startZPosition + obstacleSpawnDistance * i);

        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }
}
