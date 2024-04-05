using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstructionPipe : MonoBehaviour
{
    public Transform startPoint; // 始点
    public Transform endPoint; // 終点
    public float speed = 1.0f; // 移動速度

    private bool movingToEnd = true; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (movingToEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, speed * Time.deltaTime);
            // 終点に到達したらフラグを切り替える
            if (transform.position == endPoint.position)
                movingToEnd = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPoint.position, speed * Time.deltaTime);
            // 始点に到達したらフラグを切り替える
            if (transform.position == startPoint.position)
                movingToEnd = true;
        }
    }
}
