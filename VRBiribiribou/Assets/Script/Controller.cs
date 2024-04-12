using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("New Scene");
    }
}