using System;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;



public class clock : MonoBehaviour
{
    //只有加上此特性，才能在Inspector窗口中看到这些字段，被将引用赋值给他们
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    //没一单位指针旋转的角度
    const float hoursToDegrees = -30f;
    const float minutesToDegrees = -6f;
    const float secondsToDegrees = -6f;

    //当组件被唤醒时unity自动调用此函数
    //void Awake() { }

    //每一帧执行一次的函数
    void Update()
    {
        
        TimeSpan time = DateTime.Now.TimeOfDay;
        //Transfrom组件中用的时欧拉角，但在代码只能够用四元数，来防止万向节锁
        //Quaternion结构中的Euler方法将欧拉角转换为四元数
        //localRotation属性是相对于父级的旋转而rotation属性代表了相对于世界坐标系的旋转
        //游戏引擎中的浮点数都用单精度
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * (float)time.TotalSeconds);

    }
}
