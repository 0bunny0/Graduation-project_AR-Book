using System.Collections;
using System.IO;
using UnityEngine;

public class ScreenShoot : MonoBehaviour
{
    //just want to show my english, lol. and do you want to know why i write so much comment, bcz this 
    public GameObject UI;

    private IEnumerator Screenshot()
    {
        //bcz have to make sure all the elements are rendered, so use ienumerator to wait for the end of the frame.
        yield return new WaitForEndOfFrame(); //等待当前帧执行完后执行后续代码

        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false); //false是纹理映射mipmap，什么是纹理映射呢，

        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0); //读取屏幕像素信息并存储为纹理数据，就是全屏读取，米有空白区域

        texture.Apply();

        string name = "Screenshot_garbage sortingApp" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        //PC
        // byte[] bytes = texture.EncodeToPNG();
        // File.WriteAllBytes(Application.dataPath + "/../" + name,bytes);


        //Mobile
        NativeGallery.SaveImageToGallery(texture, "garbage sortingApp", name);


        Destroy(texture);
        UI.SetActive(true);
    }
    public void TakeScreenshot()
    {
        UI.SetActive(false);
        StartCoroutine("Screenshot");//unity协程是一个能暂停执行，暂停后立即返回，直到中断指令完成后继续执行的函数。它类似一个子线程单独出来处理一些问题，性能开销较小，但是他在一个MonoBehaviour提供的主线程里只能有一个处于运行状态的协程。
    }
}
