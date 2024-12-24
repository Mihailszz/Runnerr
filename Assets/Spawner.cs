using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;

    private float TimeBtSpawn;
    public float StartSp;

    private void Update()
    {
        if (TimeBtSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            TimeBtSpawn = StartSp;
        }
        else
        {
            TimeBtSpawn -= Time.deltaTime;
        }
    }
}
