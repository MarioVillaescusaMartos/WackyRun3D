using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DieSystem : MonoBehaviour
{
    private bool explode;

    private void OnEnable()
    {
        GetComponent<RunnerHealthSystem>().OnHealthZero += Die;
    }

    private void OnDisable()
    {
        GetComponent<RunnerHealthSystem>().OnHealthZero -= Die;
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
