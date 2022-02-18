using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RunnerHealthSystem : HealthSystem
{
    public event Action OnHealthZero = delegate { };
    public event Action OnHealthDecrease = delegate { };

    public bool INVENCIBLE;

    InputSystemKeyboard _inputSystem;

    void Start()
    {
    }

    private void Awake()
    {
        _inputSystem = GetComponent<InputSystemKeyboard>();
        INVENCIBLE = false;
    }

    private void OnEnable()
    {
        _inputSystem.OnInvencible += SetInvencible;
    }

    private void OnDisable()
    {
        _inputSystem.OnInvencible -= SetInvencible;

    }

    public override void RestHealth(int restHealthValue)
    {
        if (!INVENCIBLE)
        {
            health -= restHealthValue;
            OnHealthDecrease();
        }

        if (health <= 0)
        {
            OnHealthZero();
        }
    }

    public void SetInvencible()
    {
        if (INVENCIBLE)
        {
            INVENCIBLE = false;
        }
        else
        {
            INVENCIBLE = true;
        }
        Debug.Log("Hola: " + INVENCIBLE);
    }

    public int ReturnHealth()
    {
        return health;
    }
}
