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

    void Start()
    {
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
    }

    public int ReturnHealth()
    {
        return health;
    }
}
