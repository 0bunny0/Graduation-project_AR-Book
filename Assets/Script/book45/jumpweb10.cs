using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using Vuforia;
public class jumpweb10 : MonoBehaviour
{
    public VirtualButtonBehaviour Vb;
    private UniWebView safeBrowsing;
    
    
    
    void Start() {
        Vb.RegisterOnButtonPressed(OnButtonPressed01);
        Vb.RegisterOnButtonReleased(OnButtonReleased01);
    }
    public void OnButtonPressed01(VirtualButtonBehaviour vb){
        
        var safeBrowsing = UniWebViewSafeBrowsing.Create("https://baike.baidu.com/item/%E6%B4%8B%E5%9E%83%E5%9C%BE/8898033?fr=aladdin");
        safeBrowsing.Show();

    }
    public void OnButtonReleased01(VirtualButtonBehaviour vb)
    {
        CloseWebView();

    }
   public void CloseWebView() {
        Destroy(safeBrowsing);
        safeBrowsing = null;
    }
    

}
