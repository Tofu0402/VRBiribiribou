using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSystem : MonoBehaviour
{
    [SerializeField] private int goalCount=3;
    [SerializeField] private int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(CheckingGoal() == true)
        {
            Debug.Log("Goal");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("CheckPoint"))
        {
            count++;
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
