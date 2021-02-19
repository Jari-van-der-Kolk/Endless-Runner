using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MainVol", Mathf.Log10(sliderValue) * 20);
    }

    /////////////////////////////////////////////////////////////////////////////

}