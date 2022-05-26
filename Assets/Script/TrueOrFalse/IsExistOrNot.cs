using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsExistOrNot : MonoBehaviour
{
    //根据物体的名字来判断这个物体是否出现，出现了就给对应的变量设置为true，没有就设置为false
    private TrueOrFalse script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("TrueOrFalseObject").GetComponent<TrueOrFalse>();
        Debug.Log(script);
        
    }

    // Update is called once per frame
    private void OnEnable() {
        if(script != null){
            if(name == "egg_00"){script.egg_00 = true;}
            else if(name == "bulb_01"){script.bulb_01 = true;}
            else if(name == "banana_02"){script.banana_02 = true;}
            else if(name == "paper_03"){script.paper_03 = true;}
            else if(name == "glass_04"){script.glass_04 = true;}
            else if(name == "can_05"){script.can_05 = true;}
            else if(name == "mask_06"){script.mask_06 = true;}
            else if(name == "wet_07"){script.wet_07 = true;}
            else if(name == "resi_08"){script.resi_08 = true;}
            else if(name == "recy_09"){script.recy_09 = true;}
            else if(name == "haza_10"){script.haza_10 = true;}
            else{}
        }
    }
    private void OnDisable() {
        if(script != null){
            if(name == "egg_00"){script.egg_00 = false;}
            else if(name == "bulb_01"){script.bulb_01 = false;}
            else if(name == "banana_02"){script.banana_02 = false;}
            else if(name == "paper_03"){script.paper_03 = false;}
            else if(name == "glass_04"){script.glass_04 = false;}
            else if(name == "can_05"){script.can_05 = false;}
            else if(name == "mask_06"){script.mask_06 = false;}
            else if(name == "wet_07"){script.wet_07 = false;}
            else if(name == "resi_08"){script.resi_08 = false;}
            else if(name == "recy_09"){script.recy_09 = false;}
            else if(name == "haza_10"){script.haza_10 = false;}
            else{}
        }
    }
}
