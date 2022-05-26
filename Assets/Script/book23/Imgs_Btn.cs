using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Imgs_Btn : MonoBehaviour
{
    //book23的轮播图按钮脚本
    public GameObject obj,video;
     int btnClickNums = 1;
    
    public void clickImgBtn(){
        
        if(btnClickNums %2 == 1){
            video.SetActive(false);
            obj.SetActive(true);
            
            btnClickNums++;
        }else{
            obj.SetActive(false);
            
            btnClickNums++;
        }
    }
}
