using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Btn : MonoBehaviour
{
    //book23的视频按钮脚本
    // Start is called before the first frame update
    
    public GameObject obj;
    public GameObject pic;
    int btnClickNum = 1;
    
    public void clickVideoBtn(){
        var vp = obj.GetComponent<VideoPlayer>();
        if(btnClickNum %2 == 1){
            pic.SetActive(false);
            obj.SetActive(true);
            vp.Play();
            btnClickNum++;
        }else{
            obj.SetActive(false);
            vp.Stop();
            btnClickNum++;
        }
    }
}
