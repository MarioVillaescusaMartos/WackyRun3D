using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeSystem : MonoBehaviour
{
    [SerializeField]
    private float waitTime;
    [SerializeField]
    private float multSpeed;

    private float initial;
    private bool waitingTimer;

    // Start is called before the first frame update
    void Start()
    {
        initial = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingTimer && waitTime >= 0)
        {
            waitTime -= Time.deltaTime;

            if (waitTime < 0)
            {
                waitingTimer = false;
            }
        }
        else
        {
            waitTime = initial;

            SpeedManagerSystem.speed = SpeedManagerSystem.initialSpeed;
        }
    }

    public void SpeedUp()
    {
        waitingTimer = true;

        SpeedManagerSystem.speed = SpeedManagerSystem.speed * multSpeed;
    }
}
