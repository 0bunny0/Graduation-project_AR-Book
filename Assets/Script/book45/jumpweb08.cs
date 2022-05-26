using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using Vuforia;
public class jumpweb08 : MonoBehaviour
{
    public VirtualButtonBehaviour Vb;
    private UniWebView safeBrowsing;
    
    
    
    void Start() {
        Vb.RegisterOnButtonPressed(OnButtonPressed01);
        Vb.RegisterOnButtonReleased(OnButtonReleased01);
    }
    public void OnButtonPressed01(VirtualButtonBehaviour vb){
        
        var safeBrowsing = UniWebViewSafeBrowsing.Create("https://baike.baidu.com/item/%E5%9E%83%E5%9C%BE%E7%84%9A%E7%83%A7%E5%8F%91%E7%94%B5%E5%8E%82/4013766?fromtitle=%E5%9E%83%E5%9C%BE%E7%84%9A%E7%83%A7%E5%8E%82&fromid=15502830&fr=aladdin");
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
