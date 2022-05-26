using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using Vuforia;
public class jumpweb09 : MonoBehaviour
{
    public VirtualButtonBehaviour Vb;
    private UniWebView safeBrowsing;
    
    
    
    void Start() {
        Vb.RegisterOnButtonPressed(OnButtonPressed01);
        Vb.RegisterOnButtonReleased(OnButtonReleased01);
    }
    public void OnButtonPressed01(VirtualButtonBehaviour vb){
        
        var safeBrowsing = UniWebViewSafeBrowsing.Create("https://baike.baidu.com/item/%E5%BA%9F%E5%93%81%E6%94%B6%E8%B4%AD%E7%AB%99/2340335?fr=aladdin");
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
