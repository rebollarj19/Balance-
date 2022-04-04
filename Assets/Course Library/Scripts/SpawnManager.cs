using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject coinPrefab;
    private float spawnRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(coinPrefab, GenerateSpawnPosition(), coinPrefab.transform.rotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {

        float spawnPosX = Random.Range(-spawnRange, spawnRange);

        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        return new Vector3(spawnPosX, (float)-.5, spawnPosZ);

    }
}
