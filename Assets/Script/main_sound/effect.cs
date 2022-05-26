using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class effect : MonoBehaviour
{
    //控制音效，短促的就是音效啦，所以最好不要关音效，干巴巴地操作多没意思
    public AudioSource audioSource;
    
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


    private void Load()
    {
        audioSource.volume = PlayerPrefs.GetFloat("effectVolume");

    }
    
}
