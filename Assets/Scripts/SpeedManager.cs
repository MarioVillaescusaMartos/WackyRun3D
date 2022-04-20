using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public static float speed;

    [SerializeField]
    public float setSpeed;

    public  float initialSpeed;

    // Start is called before the first frame update
    void Start()
    {
        SpeedManagerSystem.speed = setSpeed;
        SpeedManagerSystem.initialSpeed = setSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        speed = SpeedManagerSystem.speed;
    }

    public float ReturnSpeed()
    {
        return speed;
    }
}
