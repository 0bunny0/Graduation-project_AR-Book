using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookAnimeController : MonoBehaviour
{   
    //给封面书本写的函数
    public Material mar1, mar2, mar3, mar4, mar5, mar6, mar7;
    float lastTime, lastTime1, lastTime2, lastTime3, lastTime4, lastTime5, lastTime6, lastTime7;
    float angle1 = 5; //从0度翻到180度用的变量
    float angle2 = 0;
    float angle3 = 0;
    float angle4 = 0;
    float angle5 = 0;
    float angle6 = 0;
    float angle7 = 0;
    float deangle1 = 180; //从180度翻到0度用的变量
    float deangle2 = 180;
    float deangle3 = 180;
    float deangle4 = 180;
    float deangle5 = 180;
    float deangle6 = 180;
    float deangle7 = 180;

    bool flag = false;



    private void Start()
    {
        lastTime = Time.time;
    }



    private void Update()
    {
        if (Time.time - lastTime > 0.1f && flag)
        {
            startanime();
        }
        while (deangle1 == 5)
        {
            reset();
        }
    }
    public void isShow(){
        flag = true;
    }
    public void notShow(){
        flag = false;
        reset();
        stop();
    }
    public void startanime() //动画开始函数
    {
        changeNum1();
        changeNum2();
        changeNum3();
        changeNum4();
        changeNum5();
        changeNum6();
        changeNum7();
        lastTime = Time.time;
    }
    public void reset()  //当书翻过一遍之后将数值重置
    {
        lastTime = Time.time;
        angle1 = 5;
        angle2 = 0;
        angle3 = 0;
        angle4 = 0;
        angle5 = 0;
        angle6 = 0;
        angle7 = 0;
        deangle1 = 180;
        deangle2 = 180;
        deangle3 = 180;
        deangle4 = 180;
        deangle5 = 180;
        deangle6 = 180;
        deangle7 = 180;

    }
public void stop(){
    mar1.SetFloat("_Angle", 5);
    mar2.SetFloat("_Angle", 0);
    mar3.SetFloat("_Angle", 0);
    mar4.SetFloat("_Angle", 0);
    mar5.SetFloat("_Angle", 0);
    mar6.SetFloat("_Angle", 0);
    mar7.SetFloat("_Angle", 0);
}
    public void changeNum1()
    {
        if (angle1 < 180)
        {
            angle1 += 5;
            mar1.SetFloat("_Angle", angle1);
        }
        else
        {
            if (deangle7 < 30 && deangle1 > 5)
            {
                deangle1 -= 5;
                mar1.SetFloat("_Angle", deangle1);

            }


        }
    }


    public void changeNum2()
    {
        if (angle1 > 25 && angle2 < 180)
        {
            angle2 += 5;
            mar2.SetFloat("_Angle", angle2);
        }
        else
        {
            if (deangle7 < 55 && deangle2 > 0)
            {
                deangle2 -= 5;
                mar2.SetFloat("_Angle", deangle2);

            }


        }

    }
    public void changeNum3()
    {
        if (angle1 > 50 && angle3 < 180)
        {
            angle3 += 5;
            mar3.SetFloat("_Angle", angle3);
        }
        else
        {
            if (deangle7 < 80 && deangle3 > 0)
            {
                deangle3 -= 5;
                mar3.SetFloat("_Angle", deangle3);

            }
        }

    }
    public void changeNum4()
    {
        if (angle1 > 75 && angle4 < 180)
        {
            angle4 += 5;
            mar4.SetFloat("_Angle", angle4);
        }
        else
        {
            if (deangle7 < 105 && deangle4 > 0)
            {
                deangle4 -= 5;
                mar4.SetFloat("_Angle", deangle4);

            }
        }

    }
    public void changeNum5()
    {
        if (angle1 > 100 && angle5 < 180)
        {
            angle5 += 5;
            mar5.SetFloat("_Angle", angle5);
        }
        else
        {
            if (deangle7 < 130 && deangle5 > 0)
            {
                deangle5 -= 5;
                mar5.SetFloat("_Angle", deangle5);

            }
        }

    }
    public void changeNum6()
    {
        if (angle1 > 125 && angle6 < 180)
        {
            angle6 += 5;
            mar6.SetFloat("_Angle", angle6);
        }
        else
        {
            if (deangle7 < 155 && deangle6 > 0)
            {
                deangle6 -= 5;
                mar6.SetFloat("_Angle", deangle6);

            }
        }

    }
    public void changeNum7()
    {
        if (angle1 > 150 && angle7 < 180)
        {
            angle7 += 5;
            mar7.SetFloat("_Angle", angle7);
        }
        else
        {
            if (angle7 == 180 && deangle7 > 0)
            {
                deangle7 -= 5;
                mar7.SetFloat("_Angle", deangle7);

            }
        }

    }


}
