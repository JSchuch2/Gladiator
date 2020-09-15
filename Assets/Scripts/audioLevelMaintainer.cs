using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioLevelMaintainer : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource gameaudioSource;
    public AudioSource projectileaudioSource2;

    void Awake()
    {
        gameaudioSource.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Options_VolumeLevel", 1f);
        projectileaudioSource2.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Options_VolumeLevel", 1f);
    }
}
