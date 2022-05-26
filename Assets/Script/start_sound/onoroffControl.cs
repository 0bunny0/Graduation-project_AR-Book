using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onoroffControl : MonoBehaviour
{
    //没用的脚本，放在这凑数
    public musicControl musicscript;
    public EffectControl effectscript;
    public AudioSource musicaudioSource;
    public AudioSource Effectsource;
    public Toggle toggle;
    public float musicvolume,effectVol;
    // Start is called before the first frame update
    private void Start() {
        musicvolume = musicscript.slider.value;
        effectVol = effectscript.slider.value;
    }
    public void switchMusic()
    {
        if (!toggle.isOn)
        {
            musicaudioSource.Stop();
            PlayerPrefs.SetFloat("musicVolume",0);
            musicscript.slider.value = 0;
        }
        else
        {
            PlayerPrefs.SetFloat("musicVolume",musicvolume);
            musicaudioSource.Play();
            musicscript.slider.value = musicvolume;
        }
    }

    public void switchEffect()
    {
        if (!toggle.isOn)
        {
            
            PlayerPrefs.SetFloat("effectVolume",0);
            effectscript.slider.value = 0;
        }
        else
        {
            effectscript.slider.value = effectVol;
            PlayerPrefs.SetFloat("effectVolume",effectVol);
            
        }
    }
}
