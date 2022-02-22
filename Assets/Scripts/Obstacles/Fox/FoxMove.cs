using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private int direction;
    [SerializeField]
    private float zSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + speed * Time.deltaTime * Vector3.right * direction;
        transform.position = transform.position.x * speed * Time.deltaTime * Vector3.right * direction;
    }
}
