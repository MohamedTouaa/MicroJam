﻿using UnityEngine.Audio;
using System;
using UnityEngine;

public class audioManagers : MonoBehaviour
{

    public audioSource[] sounds;

    private void Awake()
    {
        foreach( audioSource s in sounds)
        {
            s.sources = gameObject.AddComponent<AudioSource>();
            s.sources.clip = s.clip;
            s.sources.volume = s.volume;
            s.sources.pitch = s.pitch;
            s.sources.loop = s.loop;
            s.sources.playOnAwake = s.startS;
            s.sources.spatialBlend = s.specialBlend;
        }
       
    }
    
    public void playS(string name)
    {
      audioSource s = Array.Find(sounds, audioSource => audioSource.name == name);
        s.sources.Play();
        if(name == null)
        {
            Debug.LogWarning("the name is false");
            return;
        }
    }
    public void stopS(string name)
    {
        audioSource s = Array.Find(sounds, audioSource => audioSource.name == name);
        s.sources.Stop();

    }

}
