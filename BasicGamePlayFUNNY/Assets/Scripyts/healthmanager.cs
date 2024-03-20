using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthmanager : MonoBehaviour
{
    public GameObject heart;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject overtext;
    private int score = 0;
    public TMP_Text scoretext;
    
    int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("recover", 0, 5);
    }

    // Update is called once per frame
    void Update()
    {

        
        switch (health)
        {
            case 0:
                {
                    heart.gameObject.SetActive(false);
                    heart1.SetActive(false);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    heart4.gameObject.SetActive(false);
                    break;
                }
            case 1:
                {
                    heart.gameObject.SetActive(true);
                    heart1.gameObject.SetActive(false);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    heart4.gameObject.SetActive(false);
                    break;
                }
            case 2:
                {
                    heart.gameObject.SetActive(true);
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    heart4.gameObject.SetActive(false);
                    break;
                }
            case 3:
                {
                    heart.gameObject.SetActive(true);
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(false);
                    heart4.gameObject.SetActive(false);
                    break;
                }
            case 4:
                {
                    heart.gameObject.SetActive(true);
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(true);
                    heart4.gameObject.SetActive(false);
                    break;
                }
            case 5:
                {
                    heart.gameObject.SetActive(true);
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(true);
                    heart4.gameObject.SetActive(true);
                    break;
                }
        }
        }
    private void OnTriggerEnter(Collider other)
    {
        health--;
        if (health == 0)
        {
            overtext.SetActive(true);
            
        }
    }
    void recover()
    {
        if (health < 5)
        {
            if (health > 0)
            {
                health++;
            }
        }
        
    }
    public void scorey()
    {
        score += 1;
        scoretext.text = "Score: " + score;
    }
}
