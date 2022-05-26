using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectControl : MonoBehaviour
{
    //音效控制脚本
    public AudioSource audioSource;
    public Slider slider;
    public Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("effectVolume"))
        {
            PlayerPrefs.SetFloat("effectVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        audioSource.volume = slider.value;
        Save();
         if(slider.value == 0){
            toggle.isOn = false;
        }else{
            toggle.isOn = true;
        }
        
    }
    private void Load()
    {
        slider.value = PlayerPrefs.GetFloat("effectVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("effectVolume", slider.value);
    }
}
