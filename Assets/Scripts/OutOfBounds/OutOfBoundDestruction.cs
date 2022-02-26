using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundDestruction : MonoBehaviour
{
    private bool active;


    // Start is called before the first frame update
    void Start()
    {
    }
    private void FixedUpdate()
    {
    }


    public void GetOutOfBounds(bool act)
    {
        //gameObject.transform.position
        gameObject.SetActive(false);

        active = act;
    }
}
