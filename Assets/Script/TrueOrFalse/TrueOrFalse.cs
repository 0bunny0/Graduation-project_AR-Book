using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueOrFalse : MonoBehaviour
{
    //充分暴露了我的代码水平不怎么样的文件哈哈...能跑就行...原理就是在脚本间来回倒腾几个变量，匹配到了就是true，反之为false
    public GameObject img_true; //正确图像
    public GameObject img_false; //错误图像

    public bool egg_00;
    public bool bulb_01;
    public bool banana_02;
    public bool paper_03;
    public bool glass_04;
    public bool can_05;
    public bool mask_06;
    public bool wet_07;
    public bool resi_08;
    public bool recy_09;
    public bool haza_10;



    // Start is called before the first frame update
    void Start()
    {
        img_true.SetActive(false);
        img_false.SetActive(false);

        egg_00 = false;
        bulb_01 = false;
        banana_02 = false;
        paper_03 = false;
        glass_04 = false;
        can_05 = false;
        mask_06 = false;
        wet_07 = false;
        resi_08 = false;
        recy_09 = false;
        haza_10 = false;

    }

    void Update()
    {
        if ((wet_07 == true && egg_00 == true) || (wet_07 == true && banana_02 == true))
        {
            img_true.SetActive(true);
        }
        else if ((resi_08 == true && paper_03 == true) || (resi_08 == true && mask_06 == true))
        {
            img_true.SetActive(true);
        }
        else if ((recy_09 == true && glass_04 == true) || (recy_09 == true && can_05 == true))
        {
            img_true.SetActive(true);
        }
        else if (haza_10 == true && bulb_01 == true)
        {
            img_true.SetActive(true);
        }
        else if ((wet_07 == true && paper_03 == true) || (wet_07 == true && mask_06 == true) || (wet_07 == true && glass_04 == true) || (wet_07 == true && can_05 == true) || (wet_07 == true && bulb_01 == true))
        {
            img_false.SetActive(true);
        }
        else if ((resi_08 == true && egg_00 == true) || (resi_08 == true && banana_02 == true) || (resi_08 == true && glass_04 == true) || (resi_08 == true && can_05 == true) || (resi_08 == true && bulb_01 == true))
        {
            img_false.SetActive(true);
        }
        else if ((recy_09 == true && egg_00 == true) || (recy_09 == true && banana_02 == true) || (recy_09 == true && paper_03 == true) || (recy_09 == true && mask_06 == true) || (recy_09 == true && bulb_01 == true))
        {
            img_false.SetActive(true);
        }
        else if ((haza_10 == true && egg_00 == true) || (haza_10 == true && banana_02 == true) || (haza_10 == true && paper_03 == true) || (haza_10 == true && mask_06 == true) || (haza_10 == true && glass_04 == true) || (haza_10 == true && can_05 == true))
        {
            img_false.SetActive(true);
        }
        else
        {
            img_true.SetActive(false);
            img_false.SetActive(false);
        }

    }
}
