using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float followDistance;

    private Transform target;
    private bool startMove;

    Rigidbody _rb;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        startMove = false;
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
        }
        
    }

   public void GetTarget(Transform targ)
    {
        target = targ;

        startMove = true;
    }
}
