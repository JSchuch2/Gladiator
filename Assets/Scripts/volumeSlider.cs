using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class volumeSlider : MonoBehaviour
{
    private AudioSource audioSource;

    private float musicVolume = 1f;
    
    void Awake()
    {
        musicVolume = PlayerPrefs.GetFloat("Options_VolumeLevel", 1f);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSource.volume = musicVolume;
        
        PlayerPrefs.SetFloat("Options_VolumeLevel", audioSource.volume);
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }


 }
