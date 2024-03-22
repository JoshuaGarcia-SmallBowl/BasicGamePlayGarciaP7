using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 20.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    private float heat;
    private bool overheat = false;
    public Image heatbar;
    private healthmanager lol;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("cool", 1.0f, 1.0f);
        lol = GameObject.Find("helath!").GetComponent<healthmanager>();
    }

    // Update is called once per frame
    void Update()
    {
       //Movement
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * -verticalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);
        //Boundaries
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < 24)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 24);
        }
        if (transform.position.z > 31)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 31);
        }
        //Launcher Projectile Guy Worm Emoji
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (overheat == false)
            {
                if (heat < 85)
                {
                    Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                    heat += 15;
                    
                    heatbar.fillAmount = heat / 100;
                    
                }
                else
                {
                    heat += 14;
                    
                    heatbar.fillAmount = heat / 100;
                    overheat = true;
                }
            }
           
        }

    }
    void cool()
    {
        
        if (heat > 0)
        {
  
                heat -= 25;
                
                heatbar.fillAmount = heat / 100;
        

            
        }
        if (heat < 1)
        {
            heat = 0;
            overheat = false;
           
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("projo"))
        {
            Destroy(other.gameObject);
            lol.damage();
        }
        
    }
}
