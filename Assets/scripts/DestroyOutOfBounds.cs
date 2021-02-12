using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35f;
    private float lowerBound = -35f;
       
    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y>topBound || this.transform.position.y < lowerBound)
        { 
            Destroy(this.gameObject);
        }
    }
}
