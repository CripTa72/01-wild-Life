using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed, horizontalInput, verticalInput;
    public float xRange = 19.0f;
    public float yRange = 9.85f;

    public GameObject projectilePrefab;
   
    // Update is called once per frame
    void Update()
    {   
        //movimiento del Pj
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        this.transform.Translate(speed * Time.deltaTime * Vector3.right * horizontalInput);
        this.transform.Translate(speed * Time.deltaTime * Vector3.forward * verticalInput);

        CheckLimits(xRange, yRange);

        //Acciones del Pj

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //si entramos aca, hay que lanzar un proyectil
            Instantiate(projectilePrefab,
                        transform.position, 
                        projectilePrefab.transform.rotation);
        }
    }
    public void CheckLimits(float x, float y)
    {

        if (transform.position.x < -x)
        {
            //se sale a izq de la pantalla
            transform.position = new Vector3(x: -x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > x)
        {
            //se sale a der de la pantalla
            transform.position = new Vector3(x: x, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -y)
        {
            //se sale arriba de la pantalla
            transform.position = new Vector3(transform.position.x, y: -y, transform.position.z);
        }
        if (transform.position.y > y)
        {
            //se sale arriba de la pantalla
            transform.position = new Vector3(transform.position.x, y: y, transform.position.z);
        }

    }
}
