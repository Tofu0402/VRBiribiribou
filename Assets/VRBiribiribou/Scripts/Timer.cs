using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    public float TimerCount;
    void Awake()
    {
        TimerCount = 0;
    }
    void Update()
    {
        TimerCount += Time.deltaTime;
        _timerText.text = TimerCount.ToString("f2");
    }
}
