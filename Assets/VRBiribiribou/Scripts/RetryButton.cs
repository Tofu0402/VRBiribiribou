using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{
    public void OnPushedButton()
    {
        SceneManager.LoadScene("SceneManager.GetActiveScene().name"); //Œ»İ‚ÌƒQ[ƒ€SceneiPlayScenej‚©‚ç‚â‚è’¼‚µ
    }

}
