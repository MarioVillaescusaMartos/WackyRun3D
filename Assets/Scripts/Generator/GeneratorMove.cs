using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorMove : MonoBehaviour
{
    [SerializeField]
    private float nextPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        transform.position = new Vector3(0, 0, transform.position.z + nextPos);
    }
}
