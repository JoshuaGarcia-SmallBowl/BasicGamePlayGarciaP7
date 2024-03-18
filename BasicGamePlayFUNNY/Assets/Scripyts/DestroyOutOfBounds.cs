using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
    private float Bound = -30;
    private float lowerBound = 40;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < Bound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > lowerBound)
        {
            Destroy(gameObject);
      
        }

        
                
        
    }
}

