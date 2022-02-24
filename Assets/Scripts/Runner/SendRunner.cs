using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRunner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out FinalDetection detect))
        {
            detect.GetRunner(true);
        }
    }
}
