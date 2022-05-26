using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using Vuforia;


public class close : MonoBehaviour
{
    //book9的关闭按钮脚本
    public GameObject videoplane; //把video都挂载在这个空物体下
    public GameObject[] m_Child;
    
    // Start is called before the first frame update
    void Start()
    {
         GameObject[] m_Child = new GameObject[videoplane.transform.childCount]; //获取空物体下的子物体，也就是所有video
         for (int i = 0; i < m_Child.Length; i++)
        {
            m_Child[i] = videoplane.transform.GetChild(i).gameObject;
        }

         
    }
    public void closeClick(){
       for (int i = 0; i < m_Child.Length; i++)
        {
            m_Child[i].SetActive(false); //点击关闭全部隐藏
        }
    }

    
}
