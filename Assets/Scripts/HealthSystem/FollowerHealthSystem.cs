using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowerHealthSystem : HealthSystem
{
    public event Action OnHealthZero = delegate { };

    private bool touched;

    private void Start()
    {
        touched = false;
    }

    public override void RestHealth(int restHealthValue)
    {
        health -= restHealthValue;

        if (health <= 0)
        {
            if (!touched)
            {
                touched = true;
                OnHealthZero();
            }
        }
    }
}
