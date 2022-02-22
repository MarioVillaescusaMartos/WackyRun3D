using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out OutOfBoundDestruction outBound))
        {
            outBound.GetOutOfBounds(true);
        }
    }
}
