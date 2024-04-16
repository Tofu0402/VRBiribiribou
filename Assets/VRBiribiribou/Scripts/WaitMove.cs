using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaitMove : MonoBehaviour
{
    public GameObject movecube;

    private AudioSource audioSource;
    private bool isOnce = false;

    [SerializeField] private AudioClip se;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isOnce == false)
        {
            audioSource.PlayOneShot(se);
            movecube.GetComponent<Move>().enabled = true;
            isOnce = true;
        }
    }
}
