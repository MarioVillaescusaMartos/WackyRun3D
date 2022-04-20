using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float followDistance;

    private Transform target;
    private bool startMove;
    public bool touched;

    Rigidbody _rb;

    public event Action OnStartFollow = delegate { };


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        startMove = false;
        touched = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (startMove)
        {
            Destroy(gameObject.GetComponent<RoadMove>());
            Vector3 pos = Vector3.MoveTowards(transform.position, target.position - new Vector3(0, 0, followDistance), speed * Time.fixedDeltaTime);
            _rb.MovePosition(pos);

            transform.LookAt(target);

            if (!touched)
            {
                touched = true;
                OnStartFollow();
            }
        }
        
        

    }

   public void GetTarget(Transform targ)
    {
        target = targ;

        startMove = true;        
    }

    public bool ReturnTouched()
    {
        return touched;
    }
}
