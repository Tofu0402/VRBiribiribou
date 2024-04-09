using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGameOver : MonoBehaviour
{

    public void OnPushedButton()
    {
        Debug.Log("何かに当たったにぇ"); // ログを表示する
        //SceneManager.LoadScene("GameOverScene"); //ゲームオーバーのシーン（GameOmerScene）に移動する
    }
}
