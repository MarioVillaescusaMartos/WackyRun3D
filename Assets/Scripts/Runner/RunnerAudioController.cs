using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RunnerAudioController : MonoBehaviour
{
    /*[SerializeField]
    private AudioClip idle;
    [SerializeField]
    private AudioClip accelerate;
    [SerializeField]
    private AudioClip descelerate;

    private AudioSource _auso;
    private Engine _en;

    private void Awake()
    {
        _auso = GetComponent<AudioSource>();
        _en = GetComponent<Engine>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        _en.OnAccelerteSound += AccelerateSound;
        _en.OnBreakSound += BreakSound;
        _en.OnStopAccelerate += EngineSound;
       // _en.OnStopBreak += EngineSound;
    }

    private void OnDisable()
    {
        _en.OnAccelerteSound -= AccelerateSound;
        _en.OnBreakSound -= BreakSound;
        _en.OnStopAccelerate -= EngineSound;
        //_en.OnStopBreak -= EngineSound;
    }

    public void AccelerateSound()
    {
        ChangeSound(false, accelerate);
    }

    public void BreakSound()
    {
        ChangeSound(false, descelerate);
    }

    public void EngineSound()
    {
        ChangeSound(true, idle);
    }

    private void ChangeSound(bool loopBool, AudioClip audio)
    {
        _auso.clip = audio;
        _auso.loop = loopBool;
        _auso.Play();
    }*/
}
