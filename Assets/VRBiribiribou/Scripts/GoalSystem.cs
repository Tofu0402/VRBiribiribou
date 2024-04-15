using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalSystem : MonoBehaviour
{
    [SerializeField] private int goalCount=3;
    [SerializeField] private int count;
    public TMPro.TMP_Text text;
    private bool isOnce = true;

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(CheckingGoal() &&isOnce)
        {
            isOnce = false;
            Debug.Log("Goal");
            canvas.SetActive(true);
            text.text = "Game Clear!!";

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("CheckPoint"))
        {
            count++;
            Destroy(other.gameObject);
        }
    }
    private bool CheckingGoal()
    {
        if(count == goalCount)
        {
            return true;
        }
        else { return false; }
    }
    


}
