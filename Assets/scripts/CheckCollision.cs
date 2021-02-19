using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    //OnTriggerEnter se llamará automáticamente cuando un objeto físico
    //entre dentro del trigger del Game Object
    void OnTriggerEnter(Collider other)
    {   //si el animal choca contra un proyectil.
        if (other.CompareTag("Bullet"))
        { //entonces destruye.
            Destroy(this.gameObject); //destruye al animal
            Destroy(other.gameObject); //destruye lo otro
        }
    } 
}
