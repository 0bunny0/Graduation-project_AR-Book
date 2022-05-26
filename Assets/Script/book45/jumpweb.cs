using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using Vuforia;
public class jumpweb : MonoBehaviour
{
    //bug多多，一定是vufoira识别算法的问题，跟我没关系，略略略
    public VirtualButtonBehaviour Vb;
    UniWebView safeBrowsing;
    
    
    
    void Start() {
        Vb.RegisterOnButtonPressed(OnButtonPressed01);
        Vb.RegisterOnButtonReleased(OnButtonReleased01);
    }
    public void OnButtonPressed01(VirtualButtonBehaviour vb){
        
        var safeBrowsing = UniWebViewSafeBrowsing.Create("https://baike.baidu.com/item/%E6%9C%89%E6%9C%BA%E5%BA%9F%E7%89%A9/5586094?fr=aladdin");
        safeBrowsing.Show();
        safeBrowsing.OnSafeBrowsingFinished += (browsing) => {
    Debug.Log("UniWebViewSafeBrowsing is closed.");
    };


    }
    public void OnButtonReleased01(VirtualButtonBehaviour vb)
    {
        CloseWebView();

    }
   public void CloseWebView() {
        Debug.Log("abc");
}
    }
    


