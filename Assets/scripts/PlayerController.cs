using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //inputs, velocidades y rangos
    public float speed, horizontalInput, verticalInput;
    public float xRange = 19.0f;
    public float zRange = 9.85f;

    //Tipos de proyectiles
    public GameObject[] projectilePrefab;
    private int projectileIndex;


    // Update is called once per frame
    void Update()
    {
        
        //movimiento del Pj
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        this.transform.Translate(speed * Time.deltaTime * Vector3.right * horizontalInput);
        this.transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);

        CheckLimits(xRange, zRange);

        //Acciones del Pj

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //si entramos aca, hay que lanzar un proyectil
            Projectiles();
        }
    }
    void Projectiles()
    {
        projectileIndex = Random.Range(0, projectilePrefab.Length);
        Instantiate(projectilePrefab[projectileIndex],
                    transform.position,
                    projectilePrefab[projectileIndex].transform.rotation);

    }
    public void CheckLimits(float x, float z)
    {

        if (transform.position.x < -x)
        {
            //se sale a izq de la pantalla
            transform.position = new Vector3(x: -x, 
                                 transform.position.y,
                                 transform.position.z);
        }
        if (transform.position.x > x)
        {
            //se sale a der de la pantalla
            transform.position = new Vector3(x: x, 
                                 transform.position.y,
                                 transform.position.z);
        }
        if (transform.position.z < -z)
        {
            //se sale abajo de la pantalla
            transform.position = new Vector3(transform.position.x, 
                                 transform.position.y, 
                                 -z);
        }
        if (transform.position.z > z)
        {
            //se sale arriba de la pantalla
            transform.position = new Vector3(transform.position.x, 
                                 transform.position.y, 
                                 z);
        }

    }
}
