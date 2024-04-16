using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGameOver : MonoBehaviour
{

    public void OnPushedButton()
    {
        SceneManager.LoadScene("Title"); //�Q�[���I�[�o�[�̃V�[���iGameOmerScene�j�Ɉړ�����
    }
}
