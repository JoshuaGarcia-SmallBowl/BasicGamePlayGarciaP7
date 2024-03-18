using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float speed = 20.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    private float heat;
    private bool overheat = false;
    public Image heatbar;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("cool", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
       //Movement
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * -verticalInput * Time.deltaTime * speed);
        //Boundaries
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
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
                    heat += 15;
                    
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
}
