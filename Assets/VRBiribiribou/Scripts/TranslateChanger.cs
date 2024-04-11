using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateChanger : MonoBehaviour
{
    [SerializeField]
    [Tooltip("x軸の移動距離")]
    private float translateX = 0;

    [SerializeField]
    [Tooltip("y軸の移動距離")]
    private float translateY = 0;

    [SerializeField]
    [Tooltip("z軸の移動距離")]
    private float translateZ = 0;

    // Update is called once per frame
    void Update()
    {
        // X,Y,Z軸に対してそれぞれ、指定した距離ずつ移動させている。
        // deltaTimeをかけることで、フレームごとではなく、1秒ごとに移動するようにしている。
        gameObject.transform.Translate(new Vector3(translateX * Mathf.Sin(Time.time), translateY * Mathf.Sin(Time.time), translateZ * Mathf.Sin(Time.time)) / 100);
    }
}
