using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, endTime + 1f);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("StopSpawning", endTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
