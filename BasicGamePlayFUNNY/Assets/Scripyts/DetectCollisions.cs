using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class DetectCollisions : MonoBehaviour
{
    public bool dodge = false;
    public int health = 1;
    public GameObject little;
    private float offset;
    public bool splitter;
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

            {
                if (health == 1)
                {
                    if (splitter == true)
                    {
                        Split();
                        splitter = false;
                        Destroy(other.gameObject);

                    }
                    else
                    {
                        Destroy(gameObject);
                        Destroy(other.gameObject);
                    }
                }

                else
                {
                    health--;
                    Destroy(other.gameObject);
                }
            }
            
           
        }
        else
        {
            transform.position = new Vector3(Random.Range(-3, 3), 0, -2);
            dodge = false;
        }
 
        
       
    }

    void Split()
    {
        offset = transform.position.x + 1;
        Vector3 spawnpos = new Vector3(offset, 0, -3);
        Instantiate(little, spawnpos, transform.rotation);
        Vector3 downpos = new Vector3(-offset, 0, -3);
        Instantiate(little, downpos, transform.rotation);
        Destroy(gameObject);
        
    }
}
