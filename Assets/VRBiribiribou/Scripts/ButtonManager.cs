using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject canvas;
    int buttonCheck = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int Manager = PlayerPrefs.GetInt("ButtonSwitch");
        if (Manager == 1 && buttonCheck == 0)
        {
            /*mainCameraObj = GameObject.Find("Main Camera"); //Main Camereのtag名を検索
            cam = mainCameraObj.GetComponent<Camera>();
            Vector3 camPos= cam.transform.position; //Main Cameraの位置を取得
            Transform trans = cam.transform; //Min Cameraのtransformを取得
            double rotateNum = Math.PI*(trans.localEulerAngles.y)/180; //ラジアンに変換
            Vector3 pos = new Vector3(camPos.x +Mathf.Sin((float)(rotateNum)), camPos.y, camPos.z+Mathf.Cos((float)(rotateNum)));
            GameObject btn = Instantiate(btnPrefab, pos, trans.rotation);
            btn.transform.SetParent(canvas.transform);*/
            
            canvas.SetActive(true);
            buttonCheck = 1;
        }

    }
}
