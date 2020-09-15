using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    public AudioSource shootSound;
    public AudioSource getHitSound;
    public AudioSource gameMusic;
    // Start is called before the first frame update

    void Awake()
    {
        gameMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetMouseButtonDown(0))   
        {
            if (Time.timeScale == 1)
            {
                shootSound.Play();
            }
        }
    }
}
