using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    private int animalIndex;
    
    private float spawnRangeX = 25;
    private float spawnPosY;
    [SerializeField, Range(1,5)]
    private float startDelay = 2f;
    [SerializeField,Range(0.5f, 5.5f)]
    private float spawnInterval = 0.5f;
    void Start()
    {
        spawnPosY = this.transform.position.y;
        InvokeRepeating("Spawner",
            startDelay,
            spawnInterval);

    }

    // Update is called once per frame
    
    void Spawner()
    {   
        
        //posicion de generación de enemigos.
        float xRand = Random.Range(-spawnRangeX, spawnRangeX);
        animalIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(xRand, spawnPosY, 0);
        Instantiate(enemies[animalIndex],
            spawnPos, 
            enemies[animalIndex].transform.rotation);
    }
}