using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicToggle : MonoBehaviour
{
    //音乐toggle控制
    public musicControl musicscript;
    public AudioSource musicaudioSource;
    public Toggle toggle;
    public float musicvolume;
    // Start is called before the first frame update
    
   private void Start() {
       musicvolume = 1.0f;
   }
    public void switchMusic()
    {
        //value改变就调用的函数
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
}
