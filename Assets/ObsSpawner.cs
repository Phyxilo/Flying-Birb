using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsSpawner : MonoBehaviour
{
    public GameObject Obs;
    public float initSpawnRate = 4;

    private float spawnRate = 0;

    private float spawnTimer = 0;

    void Start() 
    {
        Instantiate(Obs, new Vector2(5.5f, Random.Range(-2, 2)), Quaternion.identity);
    }
    void Update()
    {
        spawnRate = initSpawnRate/ObstacleMovement.obsSpeed;
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnRate)
        {
            Instantiate(Obs, new Vector2(5.5f, Random.Range(-2, 2)), Quaternion.identity);
            spawnTimer = 0;
        }
    }
}
