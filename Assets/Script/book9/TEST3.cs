using UnityEngine;
using UnityEngine.Video;
using Vuforia;
public class TEST3 : MonoBehaviour
{
    //控制07视频的虚拟按钮
    public GameObject vplane10;
    public VirtualButtonBehaviour Vb;
    private VideoPlayer videocom10; //获取plane下的视频组件
    public GameObject videoplane;
    public GameObject[] m_Child;
    
    
    void Start() {
        Vb.RegisterOnButtonPressed(OnButtonPressed01);

         GameObject[] m_Child = new GameObject[videoplane.transform.childCount];
         for (int i = 0; i < m_Child.Length; i++)
        {
            
            m_Child[i] = videoplane.transform.GetChild(i).gameObject;

        }

        videocom10 = vplane10.GetComponent<VideoPlayer>();
        videoplane.SetActive(false);
        

       
    }
    public void OnButtonPressed01(VirtualButtonBehaviour vb){
        for (int i = 0; i < m_Child.Length; i++)
        {
            m_Child[i].SetActive(false);
        }

        vplane10.SetActive(true);
        videocom10.Play();
    }
}
