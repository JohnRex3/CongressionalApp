using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public float vol;
    public AudioMixer mixer;
    public Slider volume;

    public AudioSource audioData;

    public void Start()
    {
        volume.value = PlayerPrefs.GetFloat("MasterVolume");
    }

    public void Update()
    {
        vol = volume.value;
        PlayerPrefs.SetFloat("MasterVolume", vol);
        //Debug.Log(vol);
    }
}
