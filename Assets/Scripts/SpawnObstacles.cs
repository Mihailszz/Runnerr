using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;

     void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();

            SpawnTime = Time.time + TimeBetweenSpawn;
        }

    }
    void Spawn()
    {
        float RandomX = Random.Range(minX, maxX);
        float RandomY = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(RandomX, RandomY, 0),transform.rotation);

    }
}
