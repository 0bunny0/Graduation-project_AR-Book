using UnityEngine;
using UnityEngine.UI;

public class musicControl : MonoBehaviour
{
    //音乐控制脚本
    public AudioSource audioSource;
    public Slider slider;
    public Toggle toggle;
    
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume")) //这个playerpref是个全局类，存在本地的
        {
            PlayerPrefs.SetFloat("musicVolume",1);
            Load();
        }
        else{
            
            Load();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        audioSource.volume = slider.value;
        Save();
        if(slider.value == 0){
            toggle.isOn = false;
        }else{
            toggle.isOn = true;
        }
        
    }
    private void Load()
    {
        slider.value = PlayerPrefs.GetFloat("musicVolume");

    }
    private void Save(){
        PlayerPrefs.SetFloat("musicVolume",slider.value);
    }
    

}
