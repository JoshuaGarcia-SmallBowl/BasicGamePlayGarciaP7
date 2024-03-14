using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DetectCollisions : MonoBehaviour
{
    public bool dodge = false;
    public int health = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (dodge == false)
        {
            if (health == 1)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
            else
            {
                health--;
                Destroy(other.gameObject);
            }
           
        }
        else
        {
            transform.position = new Vector3(Random.Range(-3, 3), 0, -2);
            dodge = false;
        }
 
        
       
    }
}
