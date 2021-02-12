using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    public int animalIndex;
    [SerializeField]
    private float spawnRangeX = 25;
    private float spawnPosY;
    private void Start()
    {
        spawnPosY = this.transform.position.y;
    }
    // Update is called once per frame
    void Update()
    {
        

        if (animalIndex >= 0 && animalIndex < enemies.Length)
        {
            //el animal existe
            if (Input.GetKeyDown(KeyCode.F))
            {
                //posicion de generación de enemigos.
                float xRand = Random.Range(-spawnRangeX, spawnRangeX);
                animalIndex = Random.Range(0, enemies.Length);
                Vector3 spawnPos = new Vector3(xRand, spawnPosY, 0);
                Instantiate(enemies[animalIndex], spawnPos, enemies[animalIndex].transform.rotation);
            }
        }
        else
        {
            Debug.LogError("el Índice del enemigo a instanciar NO existe");
        }
    }
}