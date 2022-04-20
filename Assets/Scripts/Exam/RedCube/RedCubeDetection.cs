using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out RedCubeSystem cubeDetect))
        {
            cubeDetect.SpeedUp();
        }
    }
}
