using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    public static float Total = 0;
    void OnCollisionEnter(Collision other) //他のcollider/rigidbodyに触れたときに呼び出される
    {
        if (other.gameObject.CompareTag("Item")) //棒のtag名（Item）がぶつかると
        {
            
            Timer timer;
            GameObject obj = GameObject.Find("TimeManager"); // オブジェクト（TimeManager） にアタッチされたTimerのTimerCount変数を探す
            timer = obj.GetComponent<Timer>();
            Total = timer.TimerCount;
            Total = Total * 100;
            PlayerPrefs.SetInt("SCORE", (int)Total); // スコアをSCOREに代入
            PlayerPrefs.Save();
            //SceneManager.LoadScene("GameOverScene"); // ゲームオーバーの出力
            
        }

        //Debug.Log("GameOver");
    }
}
