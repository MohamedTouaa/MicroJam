using UnityEngine.Audio;
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
    
    public  void playS(string name)
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

[System.Serializable]
public class audioSource
{
    public string name;

    public AudioClip clip;
    [Range(0f, 2f)]
    public float volume;
    [Range(0.1f, 3f)]
    public float pitch;
    [Range(0.1f, 1f)]
    public float specialBlend;
    public bool loop;
    public bool startS;

    [HideInInspector]
    public AudioSource sources;

}