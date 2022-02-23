using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private int yDirection;
    [SerializeField]
    private int xDirection;
    [SerializeField]
    private float zSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zSpeed = SpeedManager.speed;
     
        transform.position = new Vector3(transform.position.x + zSpeed * Time.deltaTime * xDirection, 
            0, transform.position.z + speed *Time.deltaTime * yDirection);
    }
}
