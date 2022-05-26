using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    //视频播放脚本，写来凑数，其实直接拖控件也可以，水一下工作量
    private VideoPlayer vp;
    public Texture startTex;
    public RenderTexture renderTex;
    // Start is called before the first frame update
    void Start()
    {
        vp = GetComponent<VideoPlayer>();
    }

    private void OnEnable(){
        vp = GetComponent<VideoPlayer>();
    }
    private void OnDisable() {
        if(vp != null){
            
            Graphics.Blit(startTex, renderTex);
        }
    }
}
