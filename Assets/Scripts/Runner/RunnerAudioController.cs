using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RunnerAudioController : MonoBehaviour
{
    private AudioSource _auso;

    private void Awake()
    {
        _auso = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (PauseManager.pauseMode)
        {
            _auso.Pause();
        }
        else
        {
            _auso.Play();
        }
    }
    
}
