using UnityEngine;
using UnityEngine.Video;
using Vuforia;
public class TEST : MonoBehaviour
{
    //每一个按钮都注册了一个事件，为什么不写在一起呢，我也不知道，但是写在一起就会报错，我只好分开了..
    //控制07视频的虚拟按钮
    public GameObject vplane07;
    public VirtualButtonBehaviour Vb;
    private VideoPlayer videocom07; //获取plane下的视频组件
    public GameObject videoplane;
    public GameObject[] m_Child;
    
    
    void Start() {
        Vb.RegisterOnButtonPressed(OnButtonPressed01);

        //为了让自己的代码显得不那么小学生，特意写了一下遍历的函数，总的来说呢效果有点像web选项卡那种功能，点一个其他消失
         GameObject[] m_Child = new GameObject[videoplane.transform.childCount];
         for (int i = 0; i < m_Child.Length; i++)
        {
            
            m_Child[i] = videoplane.transform.GetChild(i).gameObject;

        }

        videocom07 = vplane07.GetComponent<VideoPlayer>();
        videoplane.SetActive(false);
        

       
    }
    public void OnButtonPressed01(VirtualButtonBehaviour vb){
        for (int i = 0; i < m_Child.Length; i++)
        {
            m_Child[i].SetActive(false);
        }

        vplane07.SetActive(true);
        videocom07.Play();
    }
}
