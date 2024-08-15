using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] AnimalPrefab;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int animalIndex = Random.Range(0, AnimalPrefab.Length);
        Instantiate(AnimalPrefab[animalIndex], spawnPosition, AnimalPrefab[animalIndex].transform.rotation);
    }
}
