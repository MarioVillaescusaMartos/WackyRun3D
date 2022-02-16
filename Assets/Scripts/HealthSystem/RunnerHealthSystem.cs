using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RunnerHealthSystem : HealthSystem
{
    public event Action OnHealthZero = delegate { };
    public event Action OnHealthDecrease = delegate { };

    public bool INVENCIBLE;

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

    public int ReturnHealth()
    {
        return health;
    }
}
