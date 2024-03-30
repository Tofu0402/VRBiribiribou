using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPipe : MonoBehaviour
{
    public float rotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime); 
    }
}
