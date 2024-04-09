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
        //Debug.Log("‰½‚©‚É“–‚½‚Á‚½‚É‚¥1");
        if (Manager == 1 && buttonCheck == 0)
        {
            Debug.Log("‰½‚©‚É“–‚½‚Á‚½‚É‚¥1");
            //Vector3 pos = mainCameraObj.transform.localPosition;
            mainCameraObj = GameObject.Find("Main Camera");
            cam = mainCameraObj.GetComponent<Camera>();
            Vector3 camPos= cam.transform.position;
            Transform trans = cam.transform;

            Vector3 pos = new Vector3( camPos.x+(5*Mathf.Sin((trans.rotation.y)%90)/10) ,camPos.y, camPos.z+(5*Mathf.Cos((trans.rotation.y)%90)/10) );

            GameObject btn = Instantiate(btnPrefab, pos, trans.rotation) as GameObject;
            btn.transform.SetParent(canvas.transform);

            //Instantiate(btn, pos, Quaternion.identity);
            //Debug.Log("‰½‚©‚É“–‚½‚Á‚½‚É‚¥2");
            buttonCheck = 1;
        }

    }
}
