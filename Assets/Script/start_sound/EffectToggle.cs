using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectToggle : MonoBehaviour
{
    //音效toggle控制
    public EffectControl effectscript;
    public AudioSource Effectsource;
    public Toggle toggle;
    public float effectVol;
    // Start is called before the first frame update

    private void Start()
    {
        effectVol = 1.0f;
    }
    public void switchEffect()
    {
        if (!toggle.isOn)
        {
            PlayerPrefs.SetFloat("effectVolume", 0);
            effectscript.slider.value = 0;
        }
        else
        {
            effectscript.slider.value = effectVol;
            PlayerPrefs.SetFloat("effectVolume", effectVol);

        }
    }
}
