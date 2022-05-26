using UnityEngine;
using Vuforia;
public class wetWEB : MonoBehaviour
{
    //弃用脚本，放在这凑数，每一个成功运行的脚本背后都有无数个试验品，这就是其中之一！
    public GameObject plane;
    public VirtualButtonBehaviour Vb;



    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed01);
        Vb.RegisterOnButtonReleased(OnButtonReleased01);



        plane.SetActive(false);

    }
    public void OnButtonPressed01(VirtualButtonBehaviour vb)
    {
        plane.SetActive(true);

    }
    public void OnButtonReleased01(VirtualButtonBehaviour vb)
    {
        plane.SetActive(false);

    }


}
