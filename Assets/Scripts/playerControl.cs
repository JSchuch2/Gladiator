using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Animator anim;
    public GameObject ProjectilePrefab;
    public GameObject playerCamera;

    private bool pauseToggle;


    public GameObject canvasRef;

    // Start is called before the first frame update
    void Start()
    {
        pauseToggle = false; 
    }

    // Update is called once per frame
    void Update()
    {
        /*
        When left click occurs use attack animation and create a projectile. projectiles position and movement is relative to the secondary camera behind players sword.
        */
        if(Input.GetMouseButtonDown(0))
        {
            if(pauseToggle == false)
            {
            anim.SetTrigger("playerAttack");
            GameObject flyingProjectile = Instantiate (ProjectilePrefab);
            flyingProjectile.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            flyingProjectile.transform.forward = playerCamera.transform.forward;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if(pauseToggle) 
            {
                Time.timeScale = 1;
                canvasRef.SetActive(false);
            }
            else 
            {
                canvasRef.SetActive(true);
                Time.timeScale = 0;
                
            }

            pauseToggle = !pauseToggle;
        }
    }

    public void resetTimeScale()
    {
        Time.timeScale = 1;
        pauseToggle = !pauseToggle;
    }
}

