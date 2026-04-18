using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeHandler : MonoBehaviour
{

    public AudioSource Music;
    float prevvalue;
    public Slider volumeslider;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Music == null)
        {
            Music = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Music.volume = volumeslider.value;

        if (Input.GetKeyDown(KeyCode.Backslash))
        {
            Debug.Log("~ pressed");
            if (Music.volume != 0){
                prevvalue = Music.volume;
                volumeslider.value = 0;
                Music.volume = 0;
            }
            else
            {
                Music.volume = prevvalue;
                volumeslider.value = prevvalue;
            }
        
        }
    }
}
