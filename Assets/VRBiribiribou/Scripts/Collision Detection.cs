using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    public static float Total = 0;
    void OnCollisionEnter(Collision other) //����collider/rigidbody�ɐG�ꂽ�Ƃ��ɌĂяo�����
    {
        if (other.gameObject.CompareTag("Item")) //�_��tag���iItem�j���Ԃ����
        {
            
            Timer timer;
            GameObject obj = GameObject.Find("TimeManager"); // �I�u�W�F�N�g�iTimeManager�j �ɃA�^�b�`���ꂽTimer��TimerCount�ϐ���T��
            timer = obj.GetComponent<Timer>();
            Total = timer.TimerCount;
            Total = Total * 100;
            PlayerPrefs.SetInt("SCORE", (int)Total); // �X�R�A��SCORE�ɑ��
            PlayerPrefs.Save();
            //SceneManager.LoadScene("GameOverScene"); // �Q�[���I�[�o�[�̏o��
            
        }

        //Debug.Log("GameOver");
    }
}
