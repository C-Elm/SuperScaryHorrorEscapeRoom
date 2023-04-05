using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAnim : MonoBehaviour
{
    AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void play_sound()
    {
        aud.Play();
    }
}
