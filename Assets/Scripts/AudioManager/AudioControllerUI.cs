using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControllerUI : MonoBehaviour
{
    public Slider musicSlider, sfxSlider;

    public void ToggleMusic()
    {
        AudioManager.instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        AudioManager.instance.ToggleSFX();
    }

    public void SetMusicVolume()
    {
        AudioManager.instance.SetMusicVolume(musicSlider.value);
    }

    public void SetSFXVolume()
    {
        AudioManager.instance.SetSFXVolume(sfxSlider.value);
    }
}
