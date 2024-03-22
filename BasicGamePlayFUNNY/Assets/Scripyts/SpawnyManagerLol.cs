using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnyManagerLol : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] animalPrefabsUp;
    private float spawnRangeX = -9;
    private float spawnPosZ = -25;
    

    private float startDelay = 2;
    private float spawnInterval = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("VerticalAnimals", 5.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnpos,
            animalPrefabs[animalIndex].transform.rotation);
    }
    void VerticalAnimals()
    {
        int animalIndexx = Random.Range(0, animalPrefabsUp.Length);
        Vector3 spawnpos = new Vector3(22, 0, Random.Range(24, 33));
        Instantiate(animalPrefabsUp[animalIndexx], spawnpos,
            animalPrefabsUp[animalIndexx].transform.rotation);
    }
}
