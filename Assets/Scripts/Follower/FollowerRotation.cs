using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerRotation : MonoBehaviour
{
    [SerializeField]
    private bool startRotation;

    [SerializeField]
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startRotation)
        {
            transform.LookAt(target);
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        startRotation = true;
    }
}
