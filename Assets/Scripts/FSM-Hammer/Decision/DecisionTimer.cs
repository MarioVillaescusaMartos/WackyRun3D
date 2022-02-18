using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionTimer : MonoBehaviour
{
    [SerializeField]
    private float waitTimeStart;
    [SerializeField]
    private float waitTimeEnd;

    private bool waitingToStart;
    private bool waitingToEnd;

    private float initialEnd;
    private float initialStart;

    // Start is called before the first frame update
    void Start()
    {
        initialStart = waitTimeStart;
        initialEnd = waitTimeEnd;


        waitingToStart = true;
        waitingToEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToStart)
        {
            if (waitTimeStart <= 0)
            {
                waitingToStart = false;
                waitingToEnd = true;
                waitTimeEnd = initialEnd;
            }
            else
            {
                waitTimeStart -= Time.deltaTime; 
            }
        }
        else if (waitingToEnd)
        {
            if (waitTimeEnd <= 0)
            {
                waitingToStart = true;
                waitingToEnd = false;
                waitTimeStart = initialStart;

            }
            else
            {
                waitTimeEnd -= Time.deltaTime;                
            }
        }
    }

    public bool ReturnTime()
    {
        return waitingToEnd;
    }
}