using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{
    public void OnPushedButton()
    {
        SceneManager.LoadScene("SceneManager.GetActiveScene().name"); //���݂̃Q�[��Scene�iPlayScene�j�����蒼��
    }

}
