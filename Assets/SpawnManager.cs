using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] locations;
    public GameObject block;

    public float timeToSpawn = 2.0f;
    public float spawnInterval = 1.0f;

    private void Update()
    {
        if (Time.time > timeToSpawn)
        {   
            SpawnBlocks();
            timeToSpawn = Time.time + spawnInterval;
        }
       
    }

    public void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, locations.Length);

        for (int i = 0; i < locations.Length ; i++)
        {
            if (i != randomIndex)
            {
                Instantiate(block, locations[i].position, Quaternion.identity);
            }
        }
    }



}
