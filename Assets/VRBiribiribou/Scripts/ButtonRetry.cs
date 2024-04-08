using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRetry : MonoBehaviour
{

    public void OnPushedButton()
    {
        //Debug.Log("何かに当たったにぇ"); // ログを表示する
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //現在のシーンをもう一度読み込む
    }
}
