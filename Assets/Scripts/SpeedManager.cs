using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public static float speed;

    [SerializeField]
    private float setSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = setSpeed;
    }

    public float ReturnSpeed()
    {
        return speed;
    }
}
