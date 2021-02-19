using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    private int animalIndex;

    private float spawnRangeX = 23f;
    private float spawnPosZ;
    [SerializeField, Range(1,5)]
    private float startDelay = 2f;
    [SerializeField,Range(0.5f, 5.5f)]
    private float spawnInterval = 0.5f;
    void Start()
    {
        spawnPosZ = this.transform.position.z;
        InvokeRepeating("Spawner",
            startDelay,
            spawnInterval);

    }
    void Spawner()
    {   
        
        //posicion de generación de enemigos.
        float xRand = Random.Range(-spawnRangeX, spawnRangeX);
        animalIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(xRand, 0, spawnPosZ);
        Instantiate(enemies[animalIndex],
            spawnPos, 
            enemies[animalIndex].transform.rotation);
    }
}