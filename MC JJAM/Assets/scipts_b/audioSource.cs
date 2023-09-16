using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class audioSource 
{
    public string name;

    public AudioClip clip;
    [Range (0f,2f)]
    public float volume;
    [Range(0.1f , 3f)]
    public float pitch;
    [Range(0.1f , 1f)]
    public float specialBlend;
    public bool loop;
    public bool startS;
   
    [HideInInspector]
    public AudioSource sources;

}
