using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMove : MonoBehaviour
{
    public float speed;
    public float segmentLength;

    Vector3 basePosition;

    float offset;

    // Start is called before the first frame update
    void Start()
    {
        basePosition = transform.position;
        offset = 0;
    }

    // Update is called once per frame
    void Update()
    {
        offset -= speed * Time.deltaTime;

        transform.position = basePosition + offset * Vector3.forward;
    }

    public void ResetPos()
    {

    }
}
