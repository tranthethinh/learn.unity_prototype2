using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private int animalIndex;
    private float spawnRangeZ = 16;
    private float spawnposX = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnRandomAnimal();

    }
    void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(spawnposX, 0, Random.Range(1, spawnRangeZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnpos, Quaternion.Euler(rotation));
        spawnpos = new Vector3(-spawnposX, 0, Random.Range(1, spawnRangeZ));
         rotation = new Vector3(0, 90, 0); 
        Instantiate(animalPrefabs[animalIndex], spawnpos, Quaternion.Euler(rotation));
        
    }
}
