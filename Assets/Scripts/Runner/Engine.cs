using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Engine : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    public float initialSpeed;
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

    public event Action<float, float, float, float> OnAccelerate = delegate { };
    public event Action<float, float, float, float> OnBreak = delegate { };
    public event Action OnStopAccelerate = delegate { };
    public event Action OnStopBreak = delegate { };

    private InputSystemKeyboard _inputSystem;
    private Rigidbody _rb;


    private void Awake()
    {
        _inputSystem = GetComponent<InputSystemKeyboard>();
        _rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        initialSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector3(_inputSystem.hor * speed, _rb.velocity.y, 0);

        if (posCounterFront <= maxFront && _inputSystem.ver > 0)
        {
            _rb.velocity = new Vector3(0, _rb.velocity.y, _inputSystem.ver * speed);

            posCounterFront += Time.deltaTime;
            posCounterBack -= Time.deltaTime;


            OnAccelerate(maxFront, maxBack, posCounterFront, posCounterBack);
        }
        else if (posCounterBack <= maxBack && _inputSystem.ver < 0)
        {
            _rb.velocity = new Vector3(0, _rb.velocity.y, _inputSystem.ver * speed);

            posCounterFront -= Time.deltaTime;
            posCounterBack += Time.deltaTime;

            OnBreak(maxFront, maxBack, posCounterFront, posCounterBack);
        }
        else
        {
            OnStopAccelerate();
            OnStopBreak();
        }

        //transform.localScale += new Vector3(sizeX*Time.deltaTime, sizeY* Time.deltaTime, sizeZ* Time.deltaTime);

    }
}