using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Engine : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float jumpSpeed;

    [SerializeField]
    private float sizeX;
    [SerializeField]
    private float sizeY;
    [SerializeField]
    private float sizeZ;

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
        _rb.velocity = new Vector3(_inputSystem.hor * speed, _rb.velocity.y, 1);
    }

    private void Jumping()
    {
        transform.localScale += new Vector3(sizeX, sizeY, sizeZ);
    }

}