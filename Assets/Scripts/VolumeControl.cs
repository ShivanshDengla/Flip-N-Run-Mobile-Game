using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour
{
    public AudioMixer audioMixer;
    public AudioMixer audioMixer2;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("MusicPara", Mathf.Log10 (volume) * 20);
    }

    public void SetVolumeSound (float volumeSound)
    {
        audioMixer2.SetFloat("SoundPara", Mathf.Log10(volumeSound) * 20);
    }

}

