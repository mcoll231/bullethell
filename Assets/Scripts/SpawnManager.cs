using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Bullets;
    public float spawnRangeX = 228;
    public float spawnPosZ = 20;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBullet", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomBullet()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int bulletIndex = Random.Range(0, Bullets.Length);
        Instantiate(Bullets[bulletIndex], spawnPos, Bullets[bulletIndex].transform.rotation);
        Debug.Log(spawnPos);
    }
}
