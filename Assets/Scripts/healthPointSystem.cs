using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class healthPointSystem : MonoBehaviour
{
    public GameObject player;

    public int maxHealth = 100;
    public int currentHealth = 100;
    public int minHealth = 0;

    public int projectileDamage = 10;


     public Image imageContainer;
     public TextMeshProUGUI textContainer;
     public Sprite hp100;
     public Sprite hp90;
     public Sprite hp80;
     public Sprite hp70;
     public Sprite hp60;
     public Sprite hp50;
     public Sprite hp40;
     public Sprite hp30;
     public Sprite hp20;
     public Sprite hp10;
     public Sprite hp0;



    // Update is called once per frame
    void Update()
    {
        
        //These if statements simply changeout the sprite used for the hp bars in the corners
        if (currentHealth == 100)
        {
        imageContainer.sprite = hp100;
        textContainer.text = "100";
        }

        if (currentHealth == 90)
        {
        imageContainer.sprite = hp90;
        textContainer.text = "90";
        }

        if (currentHealth == 80)
        {
        imageContainer.sprite = hp80;
        textContainer.text = "80";
        }

        if (currentHealth == 70)
        {
        imageContainer.sprite = hp70;
        textContainer.text = "70";
        }

        if (currentHealth == 60)
        {
        imageContainer.sprite = hp60;
        textContainer.text = "60";
        }
        if (currentHealth == 50)
        {
        imageContainer.sprite = hp50;
        textContainer.text = "50";
        }
        if (currentHealth == 40)
        {
        imageContainer.sprite = hp40;
        textContainer.text = "40";
        }
        if (currentHealth == 30)
        {
        imageContainer.sprite = hp30;
        textContainer.text = "30";
        }
        if (currentHealth == 20)
        {
        imageContainer.sprite = hp20;
        textContainer.text = "20";
        }
        if (currentHealth == 10)
        {
        imageContainer.sprite = hp10;
        textContainer.text = "10";
        }
        if (currentHealth == 0)
        {
        imageContainer.sprite = hp0;
        textContainer.text = "0";
        }


    }
    void OnTriggerEnter( Collider other )
    {
    //Meant to test if a projectiles boxcollider touches the player/AI boxcollider. This will then lower their current health value.
    if( other.gameObject.tag == "ProjectileTag" )
        {
            //Debug.Log("HP Before: " + currentHealth);
            
            //Destroy projectile after hit occurs
            Destroy(other.gameObject);

            //lowers health if not at minhealth
            if (currentHealth > minHealth)
            {
            currentHealth = currentHealth - projectileDamage;
            }
            //if object gets to minhealth destroy the object
            if (currentHealth == minHealth)
            {
               SceneManager.LoadScene(3);
            }
            
            //Debug.Log("HP After: " + currentHealth);
        }
    }
}
