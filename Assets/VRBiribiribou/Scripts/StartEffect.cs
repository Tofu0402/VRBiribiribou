using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEffect : MonoBehaviour
{

    [SerializeField] private GameObject effect;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = transform.parent.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("frame"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
                effect.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("frame"))
        {
            audioSource.Stop();
            effect.SetActive(false);
        }
    }
}
