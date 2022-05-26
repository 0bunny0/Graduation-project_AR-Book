using UnityEngine ;
using UnityEngine.UI ;
using DG.Tweening ;

public class SwitchToggle : MonoBehaviour {
   //Toggle的动画效果
   [SerializeField] RectTransform uiHandleRectTransform ; //私有变量序列化，就是可以在面板上显示
   [SerializeField] Color backgroundActiveColor ;
   [SerializeField] Color handleActiveColor ;//虽然我不用这个变量，但是还是放在这里

   Image backgroundImage, handleImage ;

   Color backgroundDefaultColor, handleDefaultColor ;

   Toggle toggle ;

   Vector2 handlePosition ;//2D向量

   void Awake ( ) {
      toggle = GetComponent <Toggle> ( ) ;

      handlePosition = uiHandleRectTransform.anchoredPosition ; //子物体的pivot相对于anchor的坐标
      backgroundImage = uiHandleRectTransform.parent.GetComponent <Image> ( ) ;
      handleImage = uiHandleRectTransform.GetComponent <Image> ( ) ;

      backgroundDefaultColor = backgroundImage.color ;
      handleDefaultColor = handleImage.color ;

      toggle.onValueChanged.AddListener (OnSwitch) ; //话说监听函数有什么用啊....【监测到触发了一个条件，就执行后续操作】

      if (toggle.isOn)
         OnSwitch (true) ;
   }

   void OnSwitch (bool on) {
      //浅浅加个动画效果，拿来主义
      //uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition ; // no anim
      uiHandleRectTransform.DOAnchorPos (on ? handlePosition * -1 : handlePosition, .4f).SetEase (Ease.InOutBack) ;

      //backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor ; // no anim
      backgroundImage.DOColor (on ? backgroundActiveColor : backgroundDefaultColor, .6f) ;

      //handleImage.color = on ? handleActiveColor : handleDefaultColor ; // no anim
      handleImage.DOColor (on ? handleActiveColor : handleDefaultColor, .4f) ;
   }

   void OnDestroy ( ) {
      toggle.onValueChanged.RemoveListener (OnSwitch) ;
   }
}
