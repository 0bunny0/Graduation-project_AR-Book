using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    //绑定在Maincamera上，已经忘了当初写它是为了干什么，但是又不敢删...
    public AudioSource soundPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playThisSoundEffect(){
        soundPlayer.Play();
    }
}
