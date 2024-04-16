using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChenger : MonoBehaviour
{
    public void LoadStage1()
    {
        SceneManager.LoadScene("Tutorial");
    }
    
    public void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    
    public void LoadStage3()
    {
        SceneManager.LoadScene("MovingStage");
    }
}
