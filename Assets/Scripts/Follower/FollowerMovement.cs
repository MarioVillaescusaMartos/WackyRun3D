using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerMovement : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float speed;

    private bool startMove;

    Rigidbody _rb;
    RoadMove _rm;


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
            transform.SetParent(null);
            Vector3 pos = Vector3.MoveTowards(transform.position, target.position - new Vector3(0, 0, 5), speed * Time.fixedDeltaTime);
            _rb.MovePosition(pos);
        }
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        startMove = true;
    }
}
