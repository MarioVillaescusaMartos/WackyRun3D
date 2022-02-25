using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FollowerParticleSystemController : MonoBehaviour
{
    public static bool dirt;
    public static bool burn;

    [SerializeField]
    private ParticleSystem dirtPart;
    [SerializeField]
    private ParticleSystem burnPart;

    private FollowerHealthSystem _follHealth;
    private FollowerMovement _follMove;

    private void Awake()
    {
        _follHealth = GetComponent<FollowerHealthSystem>();
        _follMove = GetComponent<FollowerMovement>();
    }

    private void OnEnable()
    {
        _follHealth.OnHealthZero += StartBurnout;
        _follMove.OnStartFollow += StartDirt;
    }

    private void OnDisable()
    {
        _follHealth.OnHealthZero -= StartBurnout;
        _follMove.OnStartFollow -= StartDirt;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartBurnout()
    {
        burnPart.Play(true);
        dirtPart.Stop(true);
        dirt = false;
        burn = true;
    }

    public void StartDirt()
    {
        dirtPart.Play(true);
        burnPart.Stop(true);
        dirt = true;
        burn = false;
    }
}
