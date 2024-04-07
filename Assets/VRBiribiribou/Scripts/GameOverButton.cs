using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButton : MonoBehaviour
{
    public void OnPushedButton()
    {
        
        SceneManager.LoadScene("GameOverScene"); //ゲームオーバーのScene（GemeOverScene）に移動
    }
}
