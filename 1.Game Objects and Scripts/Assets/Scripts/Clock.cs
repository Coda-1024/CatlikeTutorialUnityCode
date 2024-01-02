using System;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;



public class clock : MonoBehaviour
{
    //ֻ�м��ϴ����ԣ�������Inspector�����п�����Щ�ֶΣ��������ø�ֵ������
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    //ûһ��λָ����ת�ĽǶ�
    const float hoursToDegrees = -30f;
    const float minutesToDegrees = -6f;
    const float secondsToDegrees = -6f;

    //�����������ʱunity�Զ����ô˺���
    //void Awake() { }

    //ÿһִ֡��һ�εĺ���
    void Update()
    {
        
        TimeSpan time = DateTime.Now.TimeOfDay;
        //Transfrom������õ�ʱŷ���ǣ����ڴ���ֻ�ܹ�����Ԫ��������ֹ�������
        //Quaternion�ṹ�е�Euler������ŷ����ת��Ϊ��Ԫ��
        //localRotation����������ڸ�������ת��rotation���Դ������������������ϵ����ת
        //��Ϸ�����еĸ��������õ�����
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * (float)time.TotalSeconds);

    }
}
