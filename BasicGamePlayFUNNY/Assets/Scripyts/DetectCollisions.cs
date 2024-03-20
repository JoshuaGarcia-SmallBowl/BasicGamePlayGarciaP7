using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    public int dodge = 0;
    public int health = 1;
    public GameObject little;
    private float offset;
    public bool splitter;
    public bool necro;
    private float offsett;
    public bool regdod;
    private healthmanager abclol;
    public Slider healthslide;
    private float maxhealth;
    private bool maxset = false;
    // Start is called before th
   //e first frame update
    void Start()
    {
        abclol = GameObject.Find("helath!").GetComponent<healthmanager>();
        if (health > 1 )
        {
            healthslide.maxValue = health;
            healthslide.value = health;
            healthslide.fillRect.gameObject.SetActive(false);
        }
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag != "necro")
        {
            if (other.transform.tag != "health")
            {
                if (dodge == 0)
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
                                abclol.scorey();
                                Destroy(gameObject);
                                Destroy(other.gameObject);
                            }
                        }

                        else
                        {
                            if(maxset == false)
                            {
                                maxhealth = health;
                                maxset = true;
                            }

                            
                            
                            health--;
                            healthslide.fillRect.gameObject.SetActive(false);
                            healthslide.fillRect.gameObject.SetActive(true);
                            healthslide.value = maxhealth - health;
                            Destroy(other.gameObject);
                            

                        }
                    }


                }
                else
                {
                    transform.position = new Vector3(Random.Range(-3, 3), 0, -2);
                    dodge -= 1;
                }
            }

        }
        else
        {
            if (necro == true)
            {
                Reanimate();
                necro = false;
            }
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

    void Reanimate()
    {
        offsett = transform.position.x + 1;
        Vector3 funnypos = new Vector3(offsett, 0, -3);
        Instantiate(little, funnypos, transform.rotation);
        Vector3 downposs = new Vector3(-offsett, 0, -3);
        Instantiate(little, downposs, transform.rotation);
        Vector3 downposss = new Vector3(Random.Range(-1, 1) * 2, 0, -3);
        Instantiate(little, downposss, transform.rotation);
        
    }
}
