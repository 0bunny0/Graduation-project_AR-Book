using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    //控制音乐，我自己都忘了哪些控件绑定了这个脚本，emmm...反正绑定了就能够获取那个全局变量，然后设置音量
    public AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }


    private void Load()
    {
        audioSource.volume = PlayerPrefs.GetFloat("musicVolume");

    }
    
}
