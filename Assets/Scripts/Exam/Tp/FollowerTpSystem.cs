using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerTpSystem : TpSystem
{

    private InputSystemKeyboard _input;

    private void Awake()
    {
        _input = GetComponent<InputSystemKeyboard>();
    }

    private void OnEnable()
    {
        _input.OnTp += SetNewPosition;
    }

    private void OnDisable()
    {
        _input.OnTp -= SetNewPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void SetNewPosition()
    {
        gameObject.transform.position = tpPoint.position;
    }

    public void SetTarget(Transform point)
    {
        tpPoint = point;
    }
}
