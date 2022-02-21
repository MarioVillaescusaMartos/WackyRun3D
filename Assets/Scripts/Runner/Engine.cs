using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Engine : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float maxFront;
    [SerializeField]
    private float maxBack;    

    [SerializeField]
    private float sizeX;
    [SerializeField]
    private float sizeY;
    [SerializeField]
    private float sizeZ;

    private float posCounterFront = 0;
    private float posCounterBack = 0;

    private InputSystemKeyboard _inputSystem;
    private Rigidbody _rb;


    private void Awake()
    {
        _inputSystem = GetComponent<InputSystemKeyboard>();
        _rb = GetComponent<Rigidbody>();
    }

    /*private void OnEnable()
    {
        _inputSystem.OnJump += Jumping; 
    }

    private void OnDisable()
    {
        _inputSystem.OnJump -= Jumping;
    }*/

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector3(_inputSystem.hor * speed, _rb.velocity.y, 0);

        if (posCounterFront <= maxFront && _inputSystem.ver > 0)
        {
            _rb.velocity = new Vector3(0, _rb.velocity.y, _inputSystem.ver * speed);

            posCounterFront += Time.deltaTime;
            posCounterBack -= Time.deltaTime;
        }
        else if (posCounterBack <= maxBack && _inputSystem.ver < 0)
        {
            _rb.velocity = new Vector3(0, _rb.velocity.y, _inputSystem.ver * speed);

            posCounterFront -= Time.deltaTime;
            posCounterBack += Time.deltaTime;
        }
    }

    private void Jumping()
    {
        transform.localScale += new Vector3(sizeX, sizeY, sizeZ);
    }

}