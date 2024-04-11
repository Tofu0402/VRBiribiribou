using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateChanger : MonoBehaviour
{
    [SerializeField]
    [Tooltip("x���̈ړ�����")]
    private float translateX = 0;

    [SerializeField]
    [Tooltip("y���̈ړ�����")]
    private float translateY = 0;

    [SerializeField]
    [Tooltip("z���̈ړ�����")]
    private float translateZ = 0;

    // Update is called once per frame
    void Update()
    {
        // X,Y,Z���ɑ΂��Ă��ꂼ��A�w�肵���������ړ������Ă���B
        // deltaTime�������邱�ƂŁA�t���[�����Ƃł͂Ȃ��A1�b���ƂɈړ�����悤�ɂ��Ă���B
        gameObject.transform.Translate(new Vector3(translateX * Mathf.Sin(Time.time), translateY * Mathf.Sin(Time.time), translateZ * Mathf.Sin(Time.time)) / 100);
    }
}
