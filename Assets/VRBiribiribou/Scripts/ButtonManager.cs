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
    public GameObject target;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int Manager = PlayerPrefs.GetInt("ButtonSwitch");
        //Debug.Log("‰½‚©‚É“–‚½‚Á‚½‚É‚¥1");
        if (Manager == 1 && buttonCheck == 0)
        {
            Debug.Log("‰½‚©‚É“–‚½‚Á‚½‚É‚¥1");
            //Vector3 pos = mainCameraObj.transform.localPosition;
            mainCameraObj = GameObject.Find("Main Camera");
            cam = mainCameraObj.GetComponent<Camera>();
            Vector3 camPos= cam.transform.position;
            Transform trans = cam.transform;
            //Transform finaltrans = transform.Rotate(camPos,Vector3.up,trans.rotation.y);

            //float x = (-2-camPos.x * 10)/10 * Mathf.Cos(trans.rotation.y) - (camPos.z * 10-5)/10 * Mathf.Sin(trans.rotation.y) + camPos.x;
            //float z = (camPos.x * 10+2)/10 * Mathf.Sin(trans.rotation.y) + (5-camPos.z * 10)/10 * Mathf.Cos(trans.rotation.y) + camPos.z;

            double rotateNum = (double)Math.PI * -trans.rotation.y/180;

            float x = camPos.x + Mathf.Sin((float)rotateNum);
            float z = camPos.z + Mathf.Cos((float)rotateNum);

            Vector3 pos = new Vector3( x, camPos.y , z );
        
            
            GameObject btn = Instantiate(btnPrefab, pos, Quaternion.identity) as GameObject;
            btn.transform.SetParent(canvas.transform);
            transform.Translate(pos);
            transform.Rotate(0,trans.rotation.y,0);
            

            //Instantiate(btn, pos, Quaternion.identity);
            //Debug.Log("‰½‚©‚É“–‚½‚Á‚½‚É‚¥2");
            buttonCheck = 1;
        }

    }
}
