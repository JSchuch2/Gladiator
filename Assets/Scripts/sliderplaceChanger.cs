using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderplaceChanger : MonoBehaviour
{
    public Slider AudioSlider;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        AudioSlider.value = PlayerPrefs.GetFloat("Options_VolumeLevel", 1f);
    }
}
