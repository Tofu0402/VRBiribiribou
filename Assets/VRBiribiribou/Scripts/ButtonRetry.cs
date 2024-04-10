using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRetry : MonoBehaviour
{

    public void OnPushedButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Œ»İ‚ÌƒV[ƒ“‚ğ‚à‚¤ˆê“x“Ç‚İ‚Ş
    }
}
