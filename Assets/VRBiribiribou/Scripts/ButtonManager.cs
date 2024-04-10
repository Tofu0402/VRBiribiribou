using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Canvas canvas;
    public GameObject btnPrefab;
    int buttonCheck = 0;
    GameObject mainCameraObj;
    Camera cam;

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
            mainCameraObj = GameObject.Find("Main Camera"); //Main Camere‚Ìtag–¼‚ğŒŸõ
            cam = mainCameraObj.GetComponent<Camera>();
            Vector3 camPos= cam.transform.position; //Main Camera‚ÌˆÊ’u‚ğæ“¾
            Transform trans = cam.transform; //Min Camera‚Ìtransform‚ğæ“¾
            double rotateNum = Math.PI*(trans.localEulerAngles.y)/180;
            Vector3 pos = new Vector3(camPos.x +Mathf.Sin((float)(rotateNum)), camPos.y, camPos.z+Mathf.Cos((float)(rotateNum))); 
            GameObject btn = Instantiate(btnPrefab, pos, trans.rotation);
            btn.transform.SetParent(canvas.transform);
            buttonCheck = 1;
        }

    }
}
