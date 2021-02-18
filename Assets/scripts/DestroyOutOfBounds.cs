using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35f;
    private float lowerBound = -15f;
       
    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z>topBound)
        { 
            Destroy(this.gameObject);
        }

        if (this.transform.position.z < lowerBound)
        {   
            Debug.Log("GameOver");
            Destroy(this.gameObject);
            Time.timeScale = 0;
        }
    }
}
