using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerTpSystem : TpSystem
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

    private void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.TryGetComponent(out FollowerTpSystem tpFoll))
        {
            tpFoll.SetTarget(tpPoint);
        }
    }

    public override void SetNewPosition()
    {
        gameObject.transform.position = tpPoint.position;
    }
}
