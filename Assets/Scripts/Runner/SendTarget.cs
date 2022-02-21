using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out FollowerMovement followerMov))
        {
            followerMov.GetTarget(transform);
        }
    }
}
