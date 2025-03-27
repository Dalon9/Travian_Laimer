using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public List<Transform> SpawnPoints;


    public GameObject ObstaclePrefab;


    public void Spawn()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Count);
        GameObject.Instantiate(ObstaclePrefab, SpawnPoints[spawnIndex].position, Quaternion.identity);
    }   
}
